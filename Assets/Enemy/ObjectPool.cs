using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;

    float spawnTimer = 1f;
    bool gameIsRunning = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    IEnumerator SpawnEnemy()
    {
        while (gameIsRunning)
        {
            Instantiate<GameObject>(enemyPrefab, transform);
            yield return new WaitForSeconds(spawnTimer);
        }
        
    }
}
