using UnityEngine.SceneManagement;
using UnityEngine;

public static class GameManager 
{   
    public static void onDeath()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public static bool OtherIsTheFish(Collider2D other)
    {
        return (other.GetComponent<Fish>() != null);
    }
}
