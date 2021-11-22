using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{

    private int _currentScore = 0;

    Text _scoreText;

    void Awake()
    {
        _scoreText = GetComponent<Text>();
    }
    public void incrementScore() {
        _currentScore++;
        _scoreText.text = "Score: " + _currentScore.ToString();
    }

    public void increaseScoreBy(int increaseBy) {
        _currentScore = _currentScore + increaseBy;
        _scoreText.text = "Score: " + _currentScore.ToString();
    }
}