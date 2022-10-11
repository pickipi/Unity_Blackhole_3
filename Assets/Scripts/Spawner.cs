using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] items;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnitem", 0.0f, 0.3f);
    }
    void Spawnitem()
    {
        GameObject spawnedObject;

        if(gameManager.I.stageIndex == 0)
        {
            spawnedObject = Instantiate(items[Random.Range(0, 5)]);
        }

        else if (gameManager.I.stageIndex == 1)
        {
            spawnedObject = Instantiate(items[Random.Range(6, 11)]);
        }

        else if (gameManager.I.stageIndex == 2)
        {
            spawnedObject = Instantiate(items[Random.Range(12, items.Length)]);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
