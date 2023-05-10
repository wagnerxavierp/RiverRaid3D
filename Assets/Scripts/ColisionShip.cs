using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionShip : MonoBehaviour
{
    //Se colidir com um "Bullet"
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            FindObjectOfType<FirstPhaseManager>().AddPoints(5);
            Destroy(this.gameObject);
        }
    }
}
