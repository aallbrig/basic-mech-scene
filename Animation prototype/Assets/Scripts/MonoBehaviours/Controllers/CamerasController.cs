using MonoBehaviours.Triggers;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class CamerasController : MonoBehaviour
    {
        private void OnSpaceEnter()
        {
            Debug.Log("Space enter");
        }

        private void OnSpaceLeave()
        {
            Debug.Log("Space leave");
        }

        private void Start()
        {
            SpaceEnterTrigger.SpaceEnter += OnSpaceEnter;
            SpaceLeaveTrigger.SpaceLeave += OnSpaceLeave;
        }
    }
}