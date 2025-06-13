using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnPoint : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform _startPos;
    [SerializeField] Transform _endPos;
    void Start()
    {
        float _randomSpawnPoint = Random.Range(_startPos.position.x, _endPos.position.x);
        Debug.Log(_randomSpawnPoint);
    }

    void Update()
    {

    }
}
