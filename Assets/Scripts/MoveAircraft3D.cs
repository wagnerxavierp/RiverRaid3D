using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAircraft3D : MonoBehaviour
{
    public Rigidbody rb;

    private float movingY;
    private float movingX;

    void Start(){
        StartForce();
    }

    void Update(){
        MoveLeftRigth();
        Rotate();
    }

    private void StartForce(){
        Vector3 movement = new Vector3(
            0.0f,
            0.0f,
            800.0f
        );

        rb.AddForce(movement);
    }

    private void MoveLeftRigth()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(
            moveHorizontal,
            0.0f,
            0.0f
        );

        rb.AddForce(movement * 30);
    }

    private void Rotate(){
        movingX = Input.GetAxis("Horizontal") * (20);

        movingX *= Time.deltaTime;

        transform.Rotate(0, movingX, 0);
    } 
}
