using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionPlaneEnemy : MonoBehaviour
{
    //Se colidir com um "Bullet"
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            //Aumentar a pontuação na classe FirstPhaseManager
            FindObjectOfType<FirstPhaseManager>().AddPoints(15);

            Destroy(this.gameObject);
        }
    }
}
