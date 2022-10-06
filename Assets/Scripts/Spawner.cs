using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] items;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawnitem", 0);
        float x = Random.Range(-18.0f, 18.0f);
        float y = Random.Range(-23.0f, 23.0f);

        transform.position = new Vector3(x, y, 0);
    }
    void Spawnitem()
    {
        GameObject spawnedObject = Instantiate(items[Random.Range(0, items.Length)],
                                    transform.position, Quaternion.identity) as GameObject;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
