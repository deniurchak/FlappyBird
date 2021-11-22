using UnityEngine;


public class SeaweedCollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameManager.onDeath();
    }
}
