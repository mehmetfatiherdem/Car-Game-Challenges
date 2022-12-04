using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 35.0f;
    [SerializeField] private float _turnSpeed = 200.0f;
    private float _horizontalInput;
    private float _verticalInput;

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(_speed * Time.deltaTime * _verticalInput * Vector3.forward);
        transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime * _horizontalInput);
             
    }
}
