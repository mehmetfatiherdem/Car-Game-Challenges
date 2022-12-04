using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Vector3 _offset = new (-0.6f, 6.96f, -10.02f);

    void LateUpdate()
    {
        transform.position = _player.transform.position + _offset;
    }
}
