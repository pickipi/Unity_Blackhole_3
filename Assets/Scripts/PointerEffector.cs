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

    // SetTarget
    bool hasTarget;
    Vector3 targetPosition;
    float moveSpeed = 2.0f;

    // Á¡¼ö UI
    int score;
    public int type; // Á¡¼ö ¹èÁ¡
    public float size;


    // Planet ÃÊ±â°ª ¼³Á¤
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
        // Å¸ÀÔ º° Á¡¼ö¹èºÐ ¹× Å©±â ¹èÁ¤
        // type = Random.Range(1, 4);
        //else if (type == 1)
        //{
        //    size = 1.5f;
        //    score = 3;
        //}
        //else if (type == 2)
        //{
        //    size = 1.0f;
        //    score = 2;
        //}
        //else if (type == 3)
        //{
        //    size = 0.7f;
        //    score = 1;
        //}

        //// scale = 0.025f >> 6, 8, 10, 11, 12, 13, 15
        //if (gameObject.name == "planet (6)(Clone)" && gameObject.name == "planet (8)(Clone)" && gameObject.name == "planet (10)(Clone)" && gameObject.name == "planet (11)(Clone)"
        //    && gameObject.name == "planet (12)(Clone)" && gameObject.name == "planet (13)(Clone)" && gameObject.name == "planet (15)(Clone)")
        //{
        //    size = 0.025f;
        //    score = 4;
        //}

        ////scale = 0.05f >> 7, 9, 14, 16, 17
        //else if(gameObject.name == "planet (7)(Clone)" && gameObject.name == "planet (9)(Clone)"  && gameObject.name == "planet (14)(Clone)" 
        //    && gameObject.name == "planet (16)(Clone)" && gameObject.name == "planet (17)(Clone)")
        //{
        //    size = 0.05f;
        //    score = 5;
        //}

        if (gameObject.tag == "planet2")
        {
            size = 0.025f;
            score = 4;
        }

        else if (gameObject.tag == "planet3")
        {
            size = 0.05f;
            score = 5;
        }

        if(gameObject.tag == "planet")
        {
            type = Random.Range(1, 4);
            
            if (type == 1)
            {
                size = 2.5f;
                score = 3;
            }
            else if (type == 2)
            {
                size = 1.5f;
                score = 2;
            }
            else if (type == 3)
            {
                size = 1.0f;
                score = 1;
            }
        }


        transform.localScale = new Vector3(size, size, 0);

        speed = 0.5f;
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
            if (score == 1)
            {
                Debug.Log("size 1 Çà¼º È¹µæ");
                Absorber.transform.localScale += new Vector3(0.01f, 0.01f, 0);
                Collider.transform.localScale += new Vector3(0.001f, 0.001f, 0);

                // Ä«¸Þ¶ó ÁÜ ¾Æ¿ô ÇÑ°èÄ¡ ¼³Á¤
                if (Camera.main.orthographicSize < 20.0f)
                {
                    Camera.main.orthographicSize += 0.35f;
                    Debug.Log("Ä«¸Þ¶ó ÁÜ ¾Æ¿ô");
                }

            }

            else if (score == 2)
            {
                Debug.Log("size 2 Çà¼º È¹µæ");
                Absorber.transform.localScale += new Vector3(0.02f, 0.02f, 0);
                Collider.transform.localScale += new Vector3(0.004f, 0.004f, 0);

                // Ä«¸Þ¶ó ÁÜ ¾Æ¿ô ÇÑ°èÄ¡ ¼³Á¤
                if (Camera.main.orthographicSize < 20.0f)
                {
                    Camera.main.orthographicSize += 0.5f;
                    Debug.Log("Ä«¸Þ¶ó ÁÜ ¾Æ¿ô");
                }
            }

            else
            {
                Debug.Log("Å« Çà¼º È¹µæ");
                Absorber.transform.localScale += new Vector3(0.04f, 0.04f, 0);
                Collider.transform.localScale += new Vector3(0.01f, 0.01f, 0);

                // Ä«¸Þ¶ó ÁÜ ¾Æ¿ô ÇÑ°èÄ¡ ¼³Á¤
                if (Camera.main.orthographicSize < 20.0f)
                {
                    Camera.main.orthographicSize += 0.7f;
                    Debug.Log("Ä«¸Þ¶ó ÁÜ ¾Æ¿ô");
                }
            }
            /*
            // Ä«¸Þ¶ó ÁÜ ¾Æ¿ô ÇÑ°èÄ¡ ¼³Á¤
            if (Camera.main.orthographicSize < 20.0f &&
                (Camera.main.transform.position.x > -4.5 && Camera.main.transform.position.x < 4.5))
            {
                Camera.main.orthographicSize += 0.35f;
            }
            */
            // Player.GetComponent<Player>().rb.mass += 0.05f;
            // gameManager.GetComponent<gameManager>().addScore(score);
        }
    }

    // Áß·ÂÀå ¹þ¾î³µÀ»¶§ ´Ù½Ã ÀÛ¾ÆÁö´Â ·ÎÁ÷
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Absorber")
        {
            if (score == 1)
            {
                Debug.Log("size 1 Çà¼º È¹µæ");
                Absorber.transform.localScale -= new Vector3(0.01f, 0.01f, 0);
                Collider.transform.localScale -= new Vector3(0.001f, 0.001f, 0);

                // Ä«¸Þ¶ó ÁÜ ¾Æ¿ô ÇÑ°èÄ¡ ¼³Á¤
                if (Camera.main.orthographicSize < 20.0f)
                {
                    Camera.main.orthographicSize -= 0.35f;
                    Debug.Log("Ä«¸Þ¶ó ÁÜ ¾Æ¿ô");
                }

            }

            else if (score == 2)
            {
                Debug.Log("size 2 Çà¼º È¹µæ");
                Absorber.transform.localScale -= new Vector3(0.02f, 0.02f, 0);
                Collider.transform.localScale -= new Vector3(0.004f, 0.004f, 0);

                // Ä«¸Þ¶ó ÁÜ ¾Æ¿ô ÇÑ°èÄ¡ ¼³Á¤
                if (Camera.main.orthographicSize < 20.0f)
                {
                    Camera.main.orthographicSize -= 0.5f;
                    Debug.Log("Ä«¸Þ¶ó ÁÜ ¾Æ¿ô");
                }
            }

            else
            {
                Debug.Log("Å« Çà¼º È¹µæ");
                Absorber.transform.localScale -= new Vector3(0.04f, 0.04f, 0);
                Collider.transform.localScale -= new Vector3(0.01f, 0.01f, 0);

                // Ä«¸Þ¶ó ÁÜ ¾Æ¿ô ÇÑ°èÄ¡ ¼³Á¤
                if (Camera.main.orthographicSize < 20.0f)
                {
                    Camera.main.orthographicSize -= 0.7f;
                    Debug.Log("Ä«¸Þ¶ó ÁÜ ¾Æ¿ô");
                }
            }
        }
    }

    /*
    void OrbitAround()
    {
        transform.RotateAround(Absorber.transform.position, Vector3.down, speed * Time.deltaTime);
    }
    */

    // SetTarget
    private void FixedUpdate()
    {
        if (hasTarget)
        {
            Vector2 targetDirection = (targetPosition - transform.position).normalized;
            rb.velocity = new Vector2(targetDirection.x, targetDirection.y) * moveSpeed;
        }

    }

    public void SetTarget(Vector3 position)
    {
        targetPosition = position;
        hasTarget = true;
    }
}
