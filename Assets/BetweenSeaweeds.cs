using UnityEngine;

public class BetweenSeaweeds : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {

        if (GameLoop.OtherIsTheFish(other))
        {
            ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
            scoreKeeper.incrementScore();
        }

    }

}
