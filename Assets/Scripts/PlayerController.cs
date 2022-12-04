using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed = 35.0f;
    private float _turnSpeed = 300.0f;
    private float _horizontalInput;
    private float _verticalInput;
    public string inputID;

    void Update()
    {   
        _horizontalInput = Input.GetAxis("Horizontal" + inputID);
        _verticalInput = Input.GetAxis("Vertical" + inputID);

        transform.Translate(_speed * Time.deltaTime * _verticalInput * Vector3.forward);
        transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime * _horizontalInput);

    }
}
