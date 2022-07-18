using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OptionButtons : MonoBehaviour
{   
    public TMP_Text musicText;
    public AudioSource buttonNoise;
    public void ResetHighScore(){
        buttonNoise.Play();
        PlayerPrefs.SetInt("HighScore", 0);
    }

    public void MusicMuting(){
        buttonNoise.Play();
        if (musicText.text == "Mute"){
            musicText.text = "Unmute";
            AudioListener.volume = 0;
        }
        else{
            musicText.text = "Mute";
            AudioListener.volume = 1;
        }
    }

    public void BackButton(){
        buttonNoise.Play();
        SceneManager.LoadScene("MenuScene");
    }
}
