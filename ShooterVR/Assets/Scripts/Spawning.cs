using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{

    public GameObject Cube;
    bool spawned = false;

    void Update()
    {
        if (spawned == false)
        {
            spawned = true;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), (Random.Range(0.5f, 13)), (Random.Range(20, 100)));
        Instantiate(Cube, randomSpawnPosition, Quaternion.identity);
        yield return new WaitForSeconds(2);
        spawned = false;
    }
}
