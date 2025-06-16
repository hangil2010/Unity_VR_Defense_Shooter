using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] Transform _startPoint;
    [SerializeField] Transform _endPoint;
    [SerializeField] GameObject _enemyPrefab;
    [Header("Atteributes")]
    [SerializeField] private float _timeUntilNextSpawnSecond = 5f;

    private float _timePassed;
    private void Update()
    {
        _timePassed += Time.deltaTime;
        if (_timePassed > _timeUntilNextSpawnSecond)
        {
            SpawnEnemy();
            _timePassed = 0f;
        }
    }
    /// <summary>
    /// 특정 초마다 시작, 끝포인트 사이 랜덤한 x위치에서 적을 소환하는 방식.
    /// </summary>
    /// <returns></returns>
    private void SpawnEnemy()
    {
        float _randomSpawnPoint = Random.Range(_startPoint.position.x, _endPoint.position.x);
        Instantiate(
            _enemyPrefab,
            new Vector3(_randomSpawnPoint, transform.position.y, transform.position.z),
            Quaternion.identity);
    }
}
