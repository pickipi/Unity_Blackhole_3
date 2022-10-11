using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorber : MonoBehaviour
{
    public GameObject planet;
    public GameObject gameManager;
    public GameObject Player;
    public GameObject Collider;
    float size;

    // Start is called before the first frame update
    void Start()
    {
        planet = GameObject.FindGameObjectWithTag("planet");
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
        Player = GameObject.FindGameObjectWithTag("Player");
        Collider = GameObject.FindGameObjectWithTag("Collider");
        size = gameObject.GetComponent<PointerEffector>().size;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "planet")
        {
            
        }
    }
}
