using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigthSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnPosX = 24.0f;
    private float SpawnRangeTop = 32.0f;
    private float SpawnRangeBottom = -14.0f;
    private float startDelay = 2f;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //This will call the SpawnRandomAnimal on repeat, starting at 2 seconds, then will call it again every 1.5 seconds
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Custom Method 
    void SpawnRandomAnimal()
    {
        //Variables Lines(29 & 32)

        Vector3 SpawnPos = new Vector3(SpawnPosX, 0, Random.Range(SpawnRangeTop, SpawnRangeBottom));
        //Calls for the animals spawn at a certain a random X value between (-20,20) but a Z value of 'SpawnPosZ'

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //Calls for the animals inside the array from the value 0 to the largest value of the array

        Instantiate(animalPrefabs[animalIndex], SpawnPos, animalPrefabs[animalIndex].transform.rotation);
        //Everything put together. Spawns random animals at random X values 
    }
}
