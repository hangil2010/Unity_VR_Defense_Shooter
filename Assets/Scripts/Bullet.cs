using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _knockbackForce = 5f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(1);
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * _knockbackForce);
        }
        Destroy(gameObject);
    }
}
