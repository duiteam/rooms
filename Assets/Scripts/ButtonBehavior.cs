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

    // ���� "Player" ���봥������ʱ
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ���� "Player" ����
            playerCount++;

            // ���û�� "Player" �ڰ�ť�ϣ��������
            if (playerCount > 0)
            {
                door.SetActive(false);
            }
        }
    }

    // �� "Player" �뿪��������ʱ
    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // ���� "Player" ����
            playerCount--;

            // ���û�� "Player" �ڰ�ť�ϣ���������
            if (playerCount == 0)
            {
                door.SetActive(true);
            }
        }
    }
}