using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    private int currentScore = 0;

    private void incrementScore() {
        currentScore++;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + currentScore.ToString();
    }
}