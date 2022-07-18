using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public TMP_Text gameOverScoreText;
    public TMP_Text gameOverHighScoreText;
    void Start()
    {
        gameOverScoreText.text = UpdateScoreAndSum.gameScoreText;   
        gameOverHighScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    void Update(){
        if (UpdateScoreAndSum.score > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", UpdateScoreAndSum.score);
            print(UpdateScoreAndSum.score);
            gameOverHighScoreText.text = "HighScore: " + UpdateScoreAndSum.score.ToString();
        }
    }
}
