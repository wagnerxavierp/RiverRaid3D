using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPhaseClick : MonoBehaviour
{
    public GameObject Panel;

    //Resetar o jogo
    public void OnClickNextPhase(){
        Panel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
