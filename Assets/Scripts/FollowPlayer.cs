using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Vector3 _thirdPersonOffset = new (-0.6f, 6.96f, -10.02f);
    private Vector3 _firstPersonOffset = new (0.0f, 3.0f, 0.0f);
    private bool _cameraPos = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _cameraPos = !_cameraPos;
        }        
    }

    void LateUpdate()
    {   

        transform.position = _cameraPos ? _player.transform.position + _thirdPersonOffset : 
            _player.transform.position + _firstPersonOffset;
    }
}
