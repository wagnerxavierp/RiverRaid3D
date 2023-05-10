using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClick : MonoBehaviour
{
    public GameObject Panel;

    public void OnClickStartGame(){
        Panel.SetActive(false);
        Time.timeScale = 1;
        FindObjectOfType<FirstPhaseManager>().PlaySoundBacground();
    }
}
