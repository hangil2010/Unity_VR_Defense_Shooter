using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("References")]
    [SerializeField] CapsuleCollider _sphereCollider;
    [SerializeField] LayerMask _targetLayer;

    public void TakeDamage(int _damage)
    {
        Destroy(gameObject);
    }
}
