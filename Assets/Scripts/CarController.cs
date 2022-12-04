using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private float _speed = 50.0f;
    [SerializeField] private float _turnSpeed = 60.0f;
    private float _horizontalInput;
    private float _verticalInput;

    // Update is called once per frame
    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");

        transform.Translate(_speed * Time.deltaTime * _verticalInput * Vector3.forward);
        transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime * _horizontalInput);
             
    }
}
