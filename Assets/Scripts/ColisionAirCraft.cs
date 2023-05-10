using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionAirCraft : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("linewin"))
        {
            FindObjectOfType<FirstPhaseManager>().Win();
        }
        else if(other.gameObject.CompareTag("enemy"))
        {
            FindObjectOfType<FirstPhaseManager>().GameOver();
        }
        else if(other.gameObject.CompareTag("terreno"))
        {
            FindObjectOfType<FirstPhaseManager>().PlaySoundImpactShot();
            FindObjectOfType<FirstPhaseManager>().GameOver();
        }
    }
}
