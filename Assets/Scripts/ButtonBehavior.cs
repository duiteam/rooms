using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour
{
    public GameObject door;
    private int playerCount = 0;

    void Start()
    {

    }

    void Update()
    {

    }

    // 当有 "Player" 进入触发区域时
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 增加 "Player" 计数
            playerCount++;

            // 如果没有 "Player" 在按钮上，则禁用门
            if (playerCount > 0)
            {
                door.SetActive(false);
            }
        }
    }

    // 当 "Player" 离开触发区域时
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 减少 "Player" 计数
            playerCount--;

            // 如果没有 "Player" 在按钮上，则启用门
            if (playerCount == 0)
            {
                door.SetActive(true);
            }
        }
    }
}