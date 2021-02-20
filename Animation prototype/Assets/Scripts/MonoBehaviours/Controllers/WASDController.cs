using UnityEngine;

public class WASDController : MonoBehaviour
{
    private float _speed = 5.0f;
    private Transform _transform;
    private void Start()
    {
        _transform = transform;
    }

    private void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");
        
        _transform.Translate(hInput * _speed * Time.deltaTime, 0, vInput * _speed * Time.deltaTime);
    }
}
