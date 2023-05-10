using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPhaseManager : MonoBehaviour
{
    private int points = 0;
    private int combustivel = 36;

    public Text pointsText;
    public Text combustivelText;

    public GameObject PanelGameOver;
    public GameObject PanelNextPhase;

    public AudioSource soundShot;
    public AudioSource soundImpactShot;
    public AudioSource soundBacground;

    // Start is called before the first frame update
    void Start()
    {
        pointsText.text = "Pontuação: " + this.points;
        combustivelText.text = "Combustível: " + new string('|', this.combustivel);
        //Parar jogo
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1){
            pointsText.text = "Pontuação: " + this.points;
            combustivelText.text = "Combustível: " + new string('|', this.combustivel);

            //Remover combustivel a cada 1 segundo
            if (Time.frameCount % 60 == 0){
                RemoveCombustivel();
            }
        }

        if(combustivel <= 0){
            GameOver();
        }
    }

    public void AddPoints(int points){
        this.points += points;
    }

    public void RemoveCombustivel(){
        this.combustivel -= 2;
    }

    public void AddCombustivel(){
        this.combustivel += 15;
        if (this.combustivel > 36){
            this.combustivel = 36;
        }
    }

    public void GameOver(){
        PanelGameOver.SetActive(true);
        Time.timeScale = 0;
        StopSoundBacground();
    }

    public void Win(){
        PanelNextPhase.SetActive(true);
        Time.timeScale = 0;
        StopSoundBacground();
    }

    public void PlaySoundShot(){
        soundShot.Play();
    }

    public void PlaySoundImpactShot(){
        soundImpactShot.Play();
    }

    public void PlaySoundBacground(){
        soundBacground.Play();
    }

    public void StopSoundBacground(){
        soundBacground.Stop();
    }
}
