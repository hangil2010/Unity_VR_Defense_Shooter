using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update

    
    [Header("Atteributes")]
    [SerializeField] private float _moveSpeed = 5f;

    private Transform _movePoint;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _movePoint = GameObject.FindWithTag("MovePoint").transform;

        if (_movePoint != null)
        {
            Vector3 direction = (_movePoint.position - transform.position).normalized;
            Vector3 move = transform.position + direction * _moveSpeed * Time.fixedDeltaTime;
            _rb.MovePosition(move);
        }
    }
}
