using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] int _bulletDamage = 1;
    [SerializeField] private float _knockbackForce = 5f;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log(_bulletDamage + LevelUpManager._main._bulletDamageScale);
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(_bulletDamage + LevelUpManager._main._bulletDamageScale);
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.forward.normalized * _knockbackForce);
        }
        Destroy(gameObject);
    }
}
