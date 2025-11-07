using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGame()
    {
        // Replace "GameScene" with the name of your actual scene
        SceneManager.LoadScene("DemoLevel");
    }
}
