using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D paddleRigidBody2D;
    public float speed = 2.0f;

    public void Awake()
    {
        this.paddleRigidBody2D = GetComponent<Rigidbody2D>();
    }
}
