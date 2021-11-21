using UnityEngine;

public class BetweenSeaweeds : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D other)
    {
        if (OtherIsTheFish(other))
        {
            ScoreKeeper scoreKeeper = GameObject.FindObjectOfType<ScoreKeeper>();
            scoreKeeper.incrementScore();
        }

    }

    bool OtherIsTheFish(Collider2D other)
    {
        return (other.GetComponent<Fish>() != null);
    }
}
