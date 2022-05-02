using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        if (ball.velocity.x > 0)
        {
            //  Ball is moving Left to Right
            if (this.ball.position.y > this.transform.position.y)
            {
                // Ball is above us, move the paddle up
                paddleRigidBody2D.AddForce(Vector2.up * speed);
            }
            else if (this.ball.position.y < this.transform.position.y)
            {
                paddleRigidBody2D.AddForce(Vector2.down * speed);
            }
        } else if (ball.velocity.x < 0)
        {
            //  Ball is moving Right to Left
            if (paddleRigidBody2D.position.y > 0)
            {
                // Ball is above us, move the paddle up
                paddleRigidBody2D.AddForce(Vector2.down * speed);
            }
            else if (paddleRigidBody2D.position.y < 0)
            {
                paddleRigidBody2D.AddForce(Vector2.up * speed);
            }
        }
    }
}
