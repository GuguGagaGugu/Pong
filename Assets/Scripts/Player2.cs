using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    private float playerSpeed = 10; //скорость ракетки

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidBody.velocity = Vector2.up * playerSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidBody.velocity = Vector2.down * playerSpeed;
        }
        else
        {
            myRigidBody.velocity = Vector2.zero;
        }

    }
}

 
