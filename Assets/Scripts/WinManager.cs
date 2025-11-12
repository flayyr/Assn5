using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    [SerializeField] private int points = 0;
    [SerializeField] private float nextSceneTimer = 5.0f;
    public string currentSceneName;
    [SerializeField] AudioSource audioSource;
    bool yippee = true;

    void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
    }

    void Update()
    {
        // let the player restart the level if they need by pressing R
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadCurrentScene();
            Debug.Log("Scene reloaded!");
        }

        // check for when there's 3 points
        // play yippee and start running a timer, in 5 seconds go to the next scene
        // depending on the current scene, transition to the next one (or offer the new game)
        // and set the points back to 0, reset the timer
        if ((currentSceneName == "DemoLevel" || currentSceneName == "Level2") && points == 3)
        {
            if (yippee)
            {
                // play yippee
                audioSource.Play();
                yippee = false;
            }

            // timer ticks down
            nextSceneTimer -= Time.deltaTime;

            if (nextSceneTimer <= 0.0f)
            { // once the timer goes all the way down (5sec), change the scene
                // if the current scene is level 1 (demo adjusted), go to 2
                if (currentSceneName == "DemoLevel")
                {
                    points = 0;
                    SceneManager.LoadScene("Level2");
                    nextSceneTimer = 5.0f;
                }

                // if the current scene is level 2, go to 3
                if (currentSceneName == "Level2")
                {
                    points = 0;
                    SceneManager.LoadScene("Level3");
                    nextSceneTimer = 5.0f;
                }
            }

        }
        
        if(currentSceneName == "Level3" && points == 5)
        {
            if (yippee)
            {
                // play yippee
                audioSource.Play();
                yippee = false;
            }

            // timer ticks down
            nextSceneTimer -= Time.deltaTime;

            if (nextSceneTimer <= 0.0f)
            {
                points = 0;
                SceneManager.LoadScene("RestartScreen");
                nextSceneTimer = 5.0f;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering object has the tag "block"
        if (other.CompareTag("block"))
        {
            Destroy(other.gameObject);
            points++;
        }
    }
    
    private void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
