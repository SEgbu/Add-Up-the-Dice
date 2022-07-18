using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateScoreAndSum : MonoBehaviour
{
    public SpriteRenderer ActiveDice1;
    public SpriteRenderer ActiveDice2;
    public SpriteRenderer ActiveDice3;
    public RandomNumberGenerator randomNumberGenerator;
    public TimeUpdater timeUpdater;
    public AudioSource numberChangeNoise;
    public TMP_Text scoreText;
    public TMP_Text sumText;
    public static string gameScoreText;
    public static int score = 0;
    int sum;
    bool isScoreIncremented = false;

    void Start(){
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        randomNumberGenerator.randomNumber = Random.Range(3, 18);
    }

    void Update(){
        sum = int.Parse(ActiveDice1.sprite.name[ActiveDice1.sprite.name.Length - 1].ToString()) + int.Parse(ActiveDice2.sprite.name[ActiveDice2.sprite.name.Length - 1].ToString()) + int.Parse(ActiveDice3.sprite.name[ActiveDice3.sprite.name.Length - 1].ToString()); 
        if (isScoreIncremented == true){
            isScoreIncremented = false;
            score += 1;
        }
        if (sum == randomNumberGenerator.randomNumber){
            numberChangeNoise.Play();
            isScoreIncremented = true;
            timeUpdater.timeAdditional += 2;
            randomNumberGenerator.randomNumber = Random.Range(3, 18);
        }
        scoreText.text = "Score: " + score.ToString();
        sumText.text = randomNumberGenerator.randomNumber.ToString();
        gameScoreText = scoreText.text;
    } 
}
