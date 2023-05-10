using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSRight : MonoBehaviour
{
    public Rigidbody rb;
    private float speed = 50f;
    private float limit = 10f;

    void Start()
    {
        MoveRight();
    }

    //parar navio quando chegar no limite
    void Update()
    {
        if(transform.position.x > limit)
        {
            transform.position = new Vector3(limit, transform.position.y, transform.position.z);
        }
    }

    private void MoveRight()
    {
        Vector3 movement = new Vector3(
            3.0f,
            0.0f,
            0.0f
        );

        rb.AddForce(movement * speed);
    }
}
