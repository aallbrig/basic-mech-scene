using Cinemachine;
using MonoBehaviours.Triggers;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class CamerasController : MonoBehaviour
    {
        public GameObject player;
        public GameObject mech;
        public CinemachineVirtualCamera virtualCamera;

        private void OnSpaceEnter()
        {
            virtualCamera.LookAt = mech.transform;
        }

        private void OnSpaceLeave()
        {
            virtualCamera.LookAt = player.transform;
        }

        private void Start()
        {
            SpaceEnterTrigger.SpaceEnter += OnSpaceEnter;
            SpaceLeaveTrigger.SpaceLeave += OnSpaceLeave;
        }
    }
}