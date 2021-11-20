using UnityEngine.SceneManagement;
    

public static class GameLoop 
{   
    public static void onDeath()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
