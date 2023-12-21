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
        // 计算盒子与地板之间的相对速度
        Vector2 relativeVelocity = rb.velocity;

        // 为了模拟摩擦力，将速度方向反转并乘以摩擦系数
        Vector2 frictionForce = -relativeVelocity.normalized * frictionCoefficient;

        // 施加摩擦力
        rb.AddForce(frictionForce, ForceMode2D.Force);
    }
}

