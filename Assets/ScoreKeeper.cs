using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    private int _currentScore = 0;

    public void incrementScore() {
        _currentScore++;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + _currentScore.ToString();
    }

    public void increaseScoreBy(int increaseBy) {
        _currentScore = _currentScore + increaseBy;
        Text scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + _currentScore.ToString();
    }
}