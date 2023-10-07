using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstaculo : MonoBehaviour
{
    public GameObject[] obstaculo;
    public float tiempodearranque;
    public float repeticion;
    public GameObject spawner;
    public Transform spawnPoint;
    void Start()
    {
        StartCoroutine(SpawnRandomObject());
    }
    private IEnumerator SpawnRandomObject()
    {
        while (true)
        {
            int randomObjectIndex = Random.Range(0, obstaculo.Length);
            float minTime = 1.5f;
            float maxTime = 2.8f;
            float randomTime = Random.Range(minTime, maxTime);
            Instantiate(obstaculo[randomObjectIndex], spawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(randomTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
