using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public float frictionCoefficient = 0.1f;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // ���������ذ�֮�������ٶ�
        Vector2 relativeVelocity = rb.velocity;

        // Ϊ��ģ��Ħ���������ٶȷ���ת������Ħ��ϵ��
        Vector2 frictionForce = -relativeVelocity.normalized * frictionCoefficient;

        // ʩ��Ħ����
        rb.AddForce(frictionForce, ForceMode2D.Force);
    }
}

