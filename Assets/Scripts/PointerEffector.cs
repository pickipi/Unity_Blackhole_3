using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerEffector : MonoBehaviour
{
    public Transform target;
    public GameObject Player;
    public float orbitSpeed;
    Vector3 offSet; // 플레이어와 맞닿은 물체와의 거리

    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-18.0f, 18.0f);
        float y = Random.Range(-23.0f, 23.0f);

        transform.position = new Vector3(x, y, 0);
        //offSet = transform.position - target.position;    
        target = GameObject.FindGameObjectWithTag("Absorber").transform;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        transform.position = target.position + offSet; // 둘의 거리만큼 리셋
                                                       // transform.Rotate(new Vector3(-0.2f, -0.2f, 0) * 2);
                                                       // transform.RotateAround(target.position, Vector3.back, orbitSpeed * Time.deltaTime * 5); // 회전을 하는 로직
        offSet = transform.position - target.position; // 둘의 거리만큼 이동
    */
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = target.position;
        }
    }

    void Orbit()
    {

    }
}
