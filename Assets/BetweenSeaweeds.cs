using UnityEngine;

public class BetweenSeaweeds : MonoBehaviour
{
    ScoreKeeper _scoreKeeper;
    void Awake() 
    {
        _scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
    }
    void OnTriggerExit2D(Collider2D other)
    {

        if (GameLoop.OtherIsTheFish(other))
        {
            _scoreKeeper.incrementScore();
        }

    }

}
