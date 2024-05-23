using System;
using QFramework;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.InputSystem;
using NotImplementedException = System.NotImplementedException;

namespace MMORPG.Game
{
    public class ComboWeapon : MonoBehaviour
    {
        public bool DroppableCombo = true;
        public float DropComboDelay = 1f;
        public float ComboCoolTime = 1f;

        [InfoBox("Automatically gets all weapons attached to the current GameObject.")]
        [InfoBox("Do not make \"InitializeOnStart\" true on any Weapon!", InfoMessageType.Warning)]
        [ReadOnly]
        public Weapon[] Weapons;

        public int CurrentWeaponIndex { get; private set; }

        public Weapon CurrentWeapon => Weapons[CurrentWeaponIndex];

        public CharacterController Owner { get; private set; }

        private float _timeSinceComboFinished = -float.MaxValue;
        private float _timeSinceLastWeaponStopped = -float.MaxValue;
        private bool _inComboCooling;
        private bool _inCombo;
        private bool _fireInNextWeapon = false;

        private void Awake()
        {
            Weapons.ForEach(x =>
            {
                if (x.InitializeOnStart)
                    throw new Exception("Do not make \"InitializeOnStart\" true on any Weapon!");
            });
        }

        private void Start()
        {
            Weapons = GetComponents<Weapon>();
            Weapons.ForEach(x =>
            {
                x.OnWeaponStarted += OnWeaponStarted;
                x.OnWeaponStopped += OnWeaponStopped;
                x.OnWeaponTryInterrupt += OnWeaponTryInterrupt;
            });
            Owner = Weapons[0].Owner;
            Debug.Assert(Owner != null);
            Owner.HandleWeapon.OnWeaponChanged += OnWeaponChanged;
        }

        private void Update()
        {
            ResetCombo();
        }

        protected virtual void OnWeaponChanged(Weapon current, Weapon previous)
        {
            if (_fireInNextWeapon)
            {
                current.WeaponInputStart();
                _fireInNextWeapon = false;
            }
        }

        protected virtual void ResetCombo()
        {
            if (Weapons.Length > 1)
            {
                if (_inCombo && DroppableCombo && Time.time - _timeSinceLastWeaponStopped > DropComboDelay)
                {
                    _inCombo = false;
                    CurrentWeaponIndex = 0;
                    Owner.HandleWeapon.ChangeWeapon(CurrentWeapon, true);
                }
            }

            if (_inComboCooling && Time.time - _timeSinceComboFinished > ComboCoolTime)
            {
                Weapons[0].PreventFire = false;
                _inComboCooling = false;
            }
        }

        protected virtual void OnWeaponStarted(Weapon weapon)
        {
        }

        protected virtual void OnWeaponStopped(Weapon weapon)
        {
            ProceedToNextCombo();
        }

        protected virtual void OnWeaponTryInterrupt(Weapon weapon)
        {
            if (Weapons.Length > 1)
            {
                if (CurrentWeapon.TryInterrupt())
                {
                    _fireInNextWeapon = true;
                }
            }
        }

        protected virtual void ProceedToNextCombo()
        {
            Debug.Assert(Owner == CurrentWeapon.Owner);

            if (Weapons.Length > 1)
            {
                var newIndex = 0;
                if (CurrentWeaponIndex < Weapons.Length - 1)
                {
                    newIndex = CurrentWeaponIndex + 1;
                    _inCombo = true;
                }
                else
                {
                    _timeSinceComboFinished = Time.time;
                    Weapons[0].PreventFire = true;
                    _inComboCooling = true;
                    _inCombo = false;
                }

                _timeSinceLastWeaponStopped = Time.time;

                CurrentWeaponIndex = newIndex;
                Owner.HandleWeapon.ChangeWeapon(CurrentWeapon, true);
            }
        }
    }
}