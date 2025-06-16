using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    [Header("References")]
    [SerializeField] LayerMask _targetLayer;
    public UnityEvent _onHealthChanged;
    [Header("Atteributes")]
    public int _health;
    [SerializeField] private float _hitEffectTime;

    private void Start()
    {
        //_defaultMaterial = gameObject.GetComponent<Material>();
    }

    public void TakeDamage(int _damage)
    {
        _health -= _damage;
        if (_health <= 0)
        {
            Destroy(gameObject);
            ScoreManager._main._score++;
            return;
        }
        _onHealthChanged?.Invoke();
        StartCoroutine(HitEffect(_hitEffectTime));
    }

    /// <summary>
    /// 탄환에 피격당할 경우 특정 시간동안 피격 이펙트 발생생
    /// </summary>
    /// <param name="_time">피격 이펙트의 지속 시간</param>
    /// <returns></returns>
    private IEnumerator HitEffect(float _time)
    {
        yield return new WaitForSeconds(_time);
    }
}
