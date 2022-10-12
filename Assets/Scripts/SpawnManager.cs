using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float SpawnRangeX = 20.0f;
    private float SpawnPosZ = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);  
            Instantiate(animalPrefabs[animalIndex],SpawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
