using Common.Proto.Event;
using Google.Protobuf;
using MMORPG.System;
using MMORPG.Tool;
using QFramework;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MMORPG.Game
{
    public enum CharacterType
    {
        Player,
        Enemy
    }

    public class CharacterController : MonoBehaviour, IController
    {
        [Required]
        public EntityView Entity;
        public CharacterType CharacterType;
        public float RotationSmooth = 10f;
        public float MoveSmooth = 10f;
        [Title("Binding")]
        [Required]
        public Animator Animator;
        [Title("Action")]
        [ChildGameObjectsOnly]
        public GameObject[] AdditionalAbilityNodes;

        public bool IsMine => Entity.IsMine;

        public Rigidbody Rigidbody { get; private set; }
        public CapsuleCollider Collider { get; private set; }

        private INetworkSystem _newtwork;

        private void Awake()
        {
            _newtwork = this.GetSystem<INetworkSystem>();
            Rigidbody = GetComponent<Rigidbody>();
            Collider = GetComponent<CapsuleCollider>();
        }

        private void Update()
        {
        }

        public void SmoothRotate(Quaternion targetRotation)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, RotationSmooth * Time.deltaTime);
        }

        public void SmoothMove(Vector3 position)
        {
            transform.position = Vector3.Lerp(transform.position, position, MoveSmooth * Time.deltaTime);
        }

        public void MoveDirection(Vector3 direction)
        {
            transform.position += direction;
        }

        public void RelativeRotate(Quaternion rotation)
        {
            transform.rotation *= rotation;
        }

        public void NetworkUploadTransform(int stateId, byte[] data)
        {
            Debug.Assert(IsMine);
            _newtwork.SendToServer(new EntityTransformSyncRequest()
            {
                EntityId = Entity.EntityId,
                Transform = new()
                {
                    Direction = transform.rotation.eulerAngles.ToNetVector3(),
                    Position = transform.position.ToNetVector3()
                },
                StateId = stateId,
                Data = data == null ? ByteString.Empty : ByteString.CopyFrom(data)
            });
        }

        public IArchitecture GetArchitecture()
        {
            return GameApp.Interface;
        }

        private void OnGUI()
        {
            if (!IsInView(gameObject))
            {
                return;
            }

            float height = 2f;
            var camera = Camera.main;
            var pos = new Vector3(transform.position.x, transform.position.y + height, transform.position.z);
            Vector2 uiPos = camera.WorldToScreenPoint(pos);
            uiPos = new(uiPos.x, Screen.height - uiPos.y);

            Vector2 nameSize = GUI.skin.label.CalcSize(new("帅比"));
            GUI.color = Color.yellow;

            var rect = new Rect(uiPos.x - (nameSize.x / 2), uiPos.y - nameSize.y, nameSize.x, nameSize.y);
            GUI.Label(rect, "帅比");

        }

        // 判断物体是否处于摄像机拍摄的角度中
        private bool IsInView(GameObject go)
        {
            var worldPos = go.transform.position;
            var cameraTransform = Camera.main.transform;
            Vector2 viewPos = Camera.main.WorldToViewportPoint(worldPos);
            Vector2 dir = (worldPos - cameraTransform.position).normalized;
            float dot = Vector3.Dot(cameraTransform.forward, dir);
            return dot > 0 &&
                   viewPos.x >= 0 &&
                   viewPos.x <= 1 &&
                   viewPos.y >= 0 &&
                   viewPos.y <= 1;
        }
    }

}