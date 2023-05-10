using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisionBullet : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            FindObjectOfType<FirstPhaseManager>().PlaySoundImpactShot();
            Destroy(this.gameObject);
        }
    }
}
