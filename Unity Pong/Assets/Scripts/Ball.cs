using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 100f;

    private Rigidbody2D ballRigidBody2D;

    public void Awake()
    {
        this.ballRigidBody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetPosition();
    }

    private void AddStartingForce()
    {
        float x = Random.value < .5f ? -1f : 1f;
        float y = Random.value < .5f ? Random.Range(-1f, -.5f) : Random.Range(.5f, 1f);

        ballRigidBody2D.AddForce(new Vector2(x * speed, y * speed));
    }

    public void AddForce(Vector2 force)
    {
        ballRigidBody2D.AddForce(force);
    }

    public void ResetPosition()
    {
        ballRigidBody2D.position = Vector3.zero;
        ballRigidBody2D.velocity = Vector3.zero;

        AddStartingForce();
    }
}
