using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MMORPG;
using Sirenix.OdinInspector;
using Sirenix.Utilities;
using UnityEngine;

public class PlayerBrain : MonoBehaviour
{
    [Required]
    public CharacterController CharacterController;

#if UNITY_EDITOR
    [SerializeField]
    [ReadOnly]
    [LabelText("CurrentState")]
    private string _currentStateName = "NONE";
#endif

    // public string StartStateName = string.Empty;

    [InfoBox("Empty state machine is meaningless", InfoMessageType.Warning, "IsEmptyStates")]
    [InfoBox("The state machine name cannot be the same!", InfoMessageType.Error, "HasRepeatStateName")]
    [ListDrawerSettings(ShowIndexLabels = true, ListElementLabelName = "Name")]
    public PlayerState[] States;

    public PlayerState CurrentState { get; private set; }

    public GameInputControls InputControls { get; private set; }

    public Vector2 CurrentMovementDirection { get; private set; }

    public LocalPlayerAbility[] GetAttachLocalAbilities() => GetAttachAbilities<LocalPlayerAbility>();

    public RemotePlayerAbility[] GetAttachRemoteAbilities() => GetAttachAbilities<RemotePlayerAbility>();

    private TAbility[] GetAttachAbilities<TAbility>() where TAbility : PlayerAbility
    {
#if UNITY_EDITOR
        // 在Editor中可能会有null的情况
        if (CharacterController?.AdditionalAbilityNodes == null)
            return Array.Empty<TAbility>();
#endif
        var total = new List<TAbility>();
        total.AddRange(GetComponents<TAbility>());
        foreach (var node in CharacterController.AdditionalAbilityNodes)
        {
            total.AddRange(node.GetComponents<TAbility>());
        }
        return total.ToArray();
    }

    public void ChangeState(PlayerState state)
    {
        Debug.Assert(state != null);
        Debug.Assert(States.Contains(state));
        CurrentState?.Exit();
        CurrentState = state;
#if UNITY_EDITOR
        _currentStateName = CurrentState.Name;
#endif
        CurrentState.Enter();
    }

    public PlayerState GetState(string stateName)
    {
        return Array.Find(States, x => x.Name == stateName);
    }

    private void Awake()
    {
        CurrentState = null;
        InputControls = new();
        if (States.Length == 0) return;
        CharacterController.Entity.OnTransformSync += OnTransformEntitySync;
    }

    private void OnTransformEntitySync(EntityTransformSyncData data)
    {
        var state = States[data.StateId];
        Debug.Assert(state != null);
        if (state != CurrentState)
        {
            ChangeState(state);
        }

        state.Actions.ForEach(x => x.TransformEntitySync(data));
    }

    private void Start()
    {
        if (States.Length == 0) return;
        InitStates();
        ChangeState(States[0]);
        StartCoroutine(NetworkFixedUpdate());
    }
        
    private void Update()
    {
        if (States.Length == 0) return;
        UpdateInputValues();
        CurrentState?.Update();
        CurrentState?.EvaluateTransitions();
    }
    
    private void FixedUpdate()
    {
        if (States.Length == 0) return;
        CurrentState?.FixedUpdate();
    }
    
    
    private IEnumerator NetworkFixedUpdate()
    {
        while (true)
        {
            CurrentState?.NetworkFixedUpdate();
            yield return new WaitForSeconds(Config.NetworkUpdateDeltaTime);
        }
    }

    private void OnEnable()
    {
        InputControls.Enable();
    }

    private void OnDisable()
    {
        InputControls.Disable();
    }

    private void InitStates()
    {
        States.ForEach((x, i) =>
        {
            x.Initialize(this, i);
            x.OnTransitionEvaluated += (transition, condition) =>
            {
                ChangeState(condition ? transition.TrueState : transition.FalseState);
            };
        });
    }


    private void UpdateInputValues()
    {
        CurrentMovementDirection = InputControls.Player.Move.ReadValue<Vector2>();
    }



#if UNITY_EDITOR
    [OnInspectorGUI]
    private void OnInspectorGUI()
    {
        States?.ForEach(x => x.Brain = this);
    }

    private bool HasRepeatStateName => States.GroupBy(x => x.Name).Any(g => g.Count() > 1);

    private bool IsEmptyStates => States.Length == 0;
#endif
}