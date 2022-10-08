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
        spawnedObject = Instantiate(items[Random.Range(0, items.Length)]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
