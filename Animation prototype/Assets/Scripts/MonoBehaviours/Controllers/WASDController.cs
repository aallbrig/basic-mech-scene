using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class WASDController : MonoBehaviour
    {
        public Animator animator;

        private const float Speed = 5.0f;
        private Transform _transform;

        private void Start()
        {
            _transform = transform;
        }

        private void Update()
        {
            var hInput = Input.GetAxis("Horizontal");
            var vInput = Input.GetAxis("Vertical");
            var movement = new Vector3(hInput, 0, vInput);

            _transform.Translate(movement * Speed * Time.deltaTime);

            animator.SetFloat("speed", movement.normalized.magnitude);
        }
    }
}