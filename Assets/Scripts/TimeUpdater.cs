using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimeUpdater : MonoBehaviour
{
    TMP_Text timeText;
    public float startTime = 5;
    float timeLeft; 
    public float timeAdditional = 0;
    // Start is called before the first frame update
    void Start()
    {
        timeText = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {   
        timeLeft = (startTime - Time.timeSinceLevelLoad) + timeAdditional;
        if (timeLeft <= 0){
            SceneManager.LoadScene("GameOverScene");
        }
        else {
            timeText.text = "Time: " + timeLeft.ToString("0");
        }
    }

}
