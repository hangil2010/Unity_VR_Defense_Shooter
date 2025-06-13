using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [Header("References")]
    [SerializeField] LayerMask _targetLayer;
    [Header("Atteributes")]
    [SerializeField] private float _health;
    [SerializeField] private float _hitEffectTime;

    private void OnEnable()
    {
        //_defaultMaterial = gameObject.GetComponent<Material>();
    }
    public void TakeDamage(int _damage)
    {
        StartCoroutine(HitEffect(_hitEffectTime));
        //Destroy(gameObject);
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
