using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class HealthSliderUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Slider _healthSlider;
    [SerializeField] EnemyHealth _enemyHealth;

    private int _maxHealth;
    private void Start()
    {
        _maxHealth = _enemyHealth._health;
        Debug.Log($"Max Health: {_maxHealth}");
    }
    public void SetValue()
    {
        Debug.Log($"Current Health: {_enemyHealth._health}");
        float _value = (float)_enemyHealth._health / (float)_maxHealth;
        Debug.Log(_value);
        _healthSlider.value = _value;
    }
}
