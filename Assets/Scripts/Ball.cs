using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 300f;
    public Rigidbody2D rb;

    void Start()
    {
        ResetPosition();
    }

    private void Launch()
    {
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f) : Random.Range(0.5f, 1f);
        rb.AddForce(new Vector2(x, y) * speed);
    }

    public void ResetPosition()
    {
        rb.position = Vector3.zero;
        rb.velocity = Vector3.zero;

        Launch();
    }

    public void Addforce(Vector2 force)
    {
        rb.AddForce(force);
    }
}