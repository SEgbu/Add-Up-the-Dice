using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public AudioSource buttonNoise;
    public void OnRestartClick(){
        buttonNoise.Play();
        SceneManager.LoadScene("GameScene");
    }

    public void OnMainMenu(){
        buttonNoise.Play();
        SceneManager.LoadScene("MenuScene");
    }

    public void OnQuit(){
        buttonNoise.Play();
        Application.Quit();
    }
}
