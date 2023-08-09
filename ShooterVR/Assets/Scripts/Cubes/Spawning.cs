using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public List<GameObject> spawnedCubes = new List<GameObject>();

    public GameObject Cube;
    bool spawned = false;

    void Update()
    {

        if (GameManager.instance.timeOver == false)
        {
            if (spawned == false)
            {
                spawned = true;
                StartCoroutine(Delay());
            }
        }
        else
        {
            DestroyAllCubes();
        }
        
    }

    IEnumerator Delay()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 11), (Random.Range(0.5f, 13)), (Random.Range(20, 100)));
        GameObject newCube = Instantiate(Cube, randomSpawnPosition, Quaternion.identity); //from spawned cube it creating new object and it is assignet to newCube variable, then the variable is added to the list
        spawnedCubes.Add(newCube); //adding newCube Varaible to list

        yield return new WaitForSeconds(2);
        spawned = false;
    }

    //go through the list with spawnded cubes and destroy them after time is over
    void DestroyAllCubes()
    {
        foreach (GameObject cube in spawnedCubes)
        {
            Destroy(cube); 
        }
        spawnedCubes.Clear(); 
    }

}
