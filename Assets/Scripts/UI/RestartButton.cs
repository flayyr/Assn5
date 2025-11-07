using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        // Replace "GameScene" with the name of your actual scene
        SceneManager.LoadScene("StartScene");
    }
}
