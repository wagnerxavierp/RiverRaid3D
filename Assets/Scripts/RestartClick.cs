using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartClick : MonoBehaviour
{
    public GameObject Panel;

    //Resetar o jogo
    public void OnClickRestartGame(){
        Panel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
