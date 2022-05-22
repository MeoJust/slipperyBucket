using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] Transform[] _spawnPoints;
    [SerializeField] int _spawnDelay;
    [SerializeField] GameObject _ballToSpawn;

    void Start()
    {
        StartCoroutine(SpawnDaBalls());
    }

    IEnumerator SpawnDaBalls()
    {
        Transform spawnPoint = _spawnPoints[Random.Range(0, _spawnPoints.Length - 1)];
        Instantiate(_ballToSpawn, spawnPoint);
        yield return new WaitForSeconds(_spawnDelay);
        StartCoroutine(SpawnDaBalls());
    }
}
