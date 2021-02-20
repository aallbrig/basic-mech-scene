using System;
using UnityEngine;

namespace MonoBehaviours.Triggers
{
    public class SpaceEnterTrigger : MonoBehaviour
    {
        public static event Action SpaceEnter;

        private bool _triggered;
        
        private void OnTriggerEnter(Collider other)
        {
            if (_triggered)
                return;
            _triggered = true;
            SpaceEnter?.Invoke();
        }
    }
}