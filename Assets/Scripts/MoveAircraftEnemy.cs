using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAircraftEnemy : MonoBehaviour
{
    public Rigidbody rb;

    void Start(){
        StartForce();
    }

    private void StartForce(){
        Vector3 movement = new Vector3(
            0.0f,
            0.0f,
            -500.0f
        );

        rb.AddForce(movement);
    }
}
