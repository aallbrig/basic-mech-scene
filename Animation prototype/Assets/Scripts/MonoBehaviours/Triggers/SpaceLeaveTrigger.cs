using System;
using UnityEngine;

namespace MonoBehaviours.Triggers
{
    public class SpaceLeaveTrigger : MonoBehaviour
    {
        public static event Action SpaceLeave;
        private bool _triggered;
        private void OnTriggerEnter(Collider other)
        {
            if (_triggered)
                return;
            _triggered = true;
            SpaceLeave?.Invoke();
        }
    }
}