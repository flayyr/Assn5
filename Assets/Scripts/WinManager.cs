using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    [SerializeField] private int points = 0;
    [SerializeField] private float nextSceneTimer = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        // check for when there's 3 points
        // play yippee and start running a timer, in 5 seconds go to the next scene
        // depending on the current scene, transition to the next one (or offer the new game)
        // and set the points back to 0, reset the timer
        if(points == 3)
        {
            // if the current scene is level 1 (demo adjusted), go to 2

            // if the current scene is level 2, go to 3

            // if the current scene is level 3, go to new game screen

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
}
