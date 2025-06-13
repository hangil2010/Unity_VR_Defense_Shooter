using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUIRotation : MonoBehaviour
{

    private void FixedUpdate()
    {
        Vector3 _target = GameObject.FindWithTag("MovePoint").transform.position;
        if (_target == null) return;
        transform.LookAt(_target);
    }
}
