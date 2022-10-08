using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerEffector : MonoBehaviour
{
    // public Transform target;
    public GameObject Absorber;
    public GameObject gameManager;
    public GameObject Player;
    public GameObject Collider;

    public float speed;
    [HideInInspector] public Rigidbody2D rb;

    // 점수 UI
    int score;
    public int type; // 점수 배점
    float size;


    // Planet 초기값 설정
    void Start()
    {
        // Spawn Location Randomizing
        float x = Random.Range(-18.0f, 18.0f);
        float y = Random.Range(-23.0f, 23.0f);
        transform.position = new Vector3(x, y, 0);

        // Absorber Properties
        Absorber = GameObject.FindGameObjectWithTag("Absorber");
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
        Player = GameObject.FindGameObjectWithTag("Player");
        Collider = GameObject.FindGameObjectWithTag("Collider");

        // Random LocalScale (Planet) and Score UI
        type = Random.Range(1, 4);
        if (type == 1)
        {
            size = 1.0f;
            score = 3;


        }
        else if (type == 2)
        {
            size = 0.5f;
            score = 2;


        }
        else
        {
            size = 0.2f;
            score = 1;


        }
        transform.localScale = new Vector3(size, size, 0);

        speed = 1.0f;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Absorber")
        {
            //OrbitAround();
            //rb.mass = 0.1f;
            //Player.GetComponent<Player>().moveSpeed += 0.1f;

            Vector2 test = gameManager.GetComponent<gameManager>().direction;
            //rb.AddForce(test * 5.0f, ForceMode2D.Impulse);
            //rb.velocity = Vector2.zero;
        }
    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Absorber")
        {
            //gameManager.GetComponent<gameManager>().pushForce += 0.03f;
            //collision.transform.SetParent(Absorber.transform);

            Absorber.transform.localScale += new Vector3(0.01f, 0.01f, 0);
            Collider.transform.localScale += new Vector3(0.001f, 0.001f, 0);
            // Player.GetComponent<Player>().rb.mass += 0.05f;
            gameManager.GetComponent<gameManager>().addScore(score);
        }
    }

    /*
    void OrbitAround()
    {
        transform.RotateAround(Absorber.transform.position, Vector3.down, speed * Time.deltaTime);
    }
    */
    
}
