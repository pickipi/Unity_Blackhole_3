using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_StarCollector : MonoBehaviour
{
    public GameObject b_star;
    public GameObject panel;
    public GameObject gameManager;

    // private -> public 변경 (2022-09-29 13:41)
    public void OnTriggerEnter2D(Collider2D collision)
    {
        ICollectible collectible = collision.GetComponent<ICollectible>();
        if (collectible != null)
        {
            collectible.Collect();

        }

        // Collector와 반대의 조건 달기
        if (collision.gameObject.tag == "star")
        {
            Destroy(collision.gameObject);

            // '적 블랙홀 성장중' 로직
            GameObject.FindGameObjectWithTag("b_star").transform.localScale += new Vector3(0.02f, 0.02f, 0);
        }

        // OnTriggerEnter = 닿았을때 로직
        if (collision.gameObject.TryGetComponent<Player>(out Player player))
        {
            panel.SetActive(true); // 재시작 패널 활성화
            Time.timeScale = 0.0f; // Unity 모든 시간 Stop
                                   // gameManager.I.retry();

            //if ((GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.x + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.x
            //    && GameObject.FindGameObjectWithTag("MagnetCollider").transform.localScale.y + 1.5f < GameObject.FindGameObjectWithTag("b_star").transform.localScale.y))
            //{

            //}
        }
    }
}