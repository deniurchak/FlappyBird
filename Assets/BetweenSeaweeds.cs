using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetweenSeaweeds : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
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
