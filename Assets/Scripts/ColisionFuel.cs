using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionFuel : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindObjectOfType<FirstPhaseManager>().AddCombustivel();
            Destroy(this.gameObject);
        }
    }
}
