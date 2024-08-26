using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text highScoreText;
    public static int scoreCount;
    public static int highScoreCount;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreCount;
        highScoreText.text = "High Score: " + highScoreCount;
    }
}
