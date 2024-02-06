using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour

{
    [SerializeField] private float _timeToSpawn;
    [SerializeField] private GameObject _enemyPrefab;
    [SerializeField] private Transform[] _spawnPoints;
    private float _curruntTimer;

    private void Start()
    {
        ResetTimer();
    }
    void Update()
    {
       _curruntTimer -= Time.deltaTime;
       if (_curruntTimer <=0.0f)
       {
        int index = Random.Range(0, _spawnPoints.Length);
        Instantiate(_enemyPrefab, _spawnPoints[index].position, _spawnPoints[index].rotation);
        ResetTimer();
       } 
    } 
    private void ResetTimer()
    {
    _curruntTimer = _timeToSpawn;
    }
}