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
    public int _health = 3;
    [SerializeField] string _targetTagName;
    [SerializeField] private float _hitEffectTime;

    private bool _isHitBarricade = false;

    private void OnEnable()
    {
        _health += LevelUpManager._main._enemyHealthScale;
    }

    public void TakeDamage(int _damage)
    {
        _health -= _damage;
        if (_health <= 0)
        {
            Destroy(gameObject);
            return;
        }
        _onHealthChanged?.Invoke();
        StartCoroutine(HitEffect(_hitEffectTime));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(_targetTagName))
        {
            _isHitBarricade = true;
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        if (_isHitBarricade)
        {
            if (ScoreManager._main._score <= 0) { }
            else ScoreManager._main._score--;
            if (ExpManager._main.Exp <= 0) { }
            else ExpManager._main.Exp--;
            ExpManager._main._requiredExp++;
        }
        else
        {
            ScoreManager._main._score++;
            ExpManager._main.Exp++;
            ExpManager._main._requiredExp--;
        }
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
