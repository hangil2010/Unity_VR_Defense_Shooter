using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    /// <summary>
    /// NavMesh를 사용하는 것도 좋을 거 같으나, 맵 내 포인트로 이동하게 하는 것이 더 좋다고 판단.
    /// </summary>
    // Start is called before the first frame update

    [Header("References")]
    [SerializeField] private Transform _movePoint;
    [Header("Atteributes")]
    [SerializeField] private float _moveSpeed = 5f;

    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (_movePoint != null)
        {
            Vector3 direction = (_movePoint.position - transform.position).normalized;
            Vector3 move = transform.position + direction * _moveSpeed * Time.fixedDeltaTime;
            _rb.MovePosition(move);
        }
    }
}
