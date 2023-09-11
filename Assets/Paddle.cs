using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    private const int playerSpeed = 5; //скорость ракетки


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            myRigidBody.velocity = Vector2.up * playerSpeed;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            myRigidBody.velocity = Vector2.down * playerSpeed;
        }
    }
}
