using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // The name of the scene to load
    public string nextSceneName;

    // The delay before the next scene can be loaded
    public float delay = 5f;

    // The timer for the space bar delay
    private float spaceBarTimer = 0f;

    // Whether the game object is currently active
    private bool isGameObjectActive = false;

    // The game object to activate and deactivate
    public GameObject SpaceBarPicture;

    // The timer for the second delay
    private float secondDelayTimer = 0f;

    // The maximum time for the second delay
    public float secondDelayMaxTime = 89f;

    // Update is called once per frame
    void Update()
    {
        // Check if the space bar has been pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // If this is the first press, start the timer and activate the game object
            if (!isGameObjectActive)
            {
                spaceBarTimer = 0f;
                SpaceBarPicture.SetActive(true);
                SpaceBarPicture.GetComponent<SpaceBarButtonOpacity>().Activate();
                isGameObjectActive = true;
            }
            // If two space bar presses have been made and the game object is still active, load the next scene
            else if (spaceBarTimer < delay)
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }

        // Add the elapsed time since the last frame to the space bar timer
        spaceBarTimer += Time.deltaTime;

        // Deactivate the game object if the delay is over
        if (spaceBarTimer >= delay && isGameObjectActive)
        {
            SpaceBarPicture.SetActive(false);
            isGameObjectActive = false;
        }

        // Check if the second delay has been reached
        if (secondDelayTimer >= secondDelayMaxTime)
        {
            SceneManager.LoadScene(nextSceneName);
        }

        // Add the elapsed time since the last frame to the second delay timer
        secondDelayTimer += Time.deltaTime;
    }
}