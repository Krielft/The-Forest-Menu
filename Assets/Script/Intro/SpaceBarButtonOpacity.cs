using UnityEngine;
using UnityEngine.UI;

public class SpaceBarButtonOpacity : MonoBehaviour
{
    // The time it takes to change the opacity from 0 to 1 and from 1 to 0
    public float fadeTime = 3f;

    // The delay between fade in and fade out
    public float delayTime = 2f;

    // The raw image to change opacity
    private RawImage spaceBarButton;

    // The target opacity
    private float targetOpacity = 0f;

    // The current opacity
    private float currentOpacity = 0f;

    // The time elapsed since the last opacity change
    private float timeElapsed = 0f;

    // Whether the game object is currently active
    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        spaceBarButton = GetComponent<RawImage>();
        spaceBarButton.color = new Color(spaceBarButton.color.r, spaceBarButton.color.g, spaceBarButton.color.b, currentOpacity);
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the game object is active
        if (isActive)
        {
            // Increment the time elapsed
            timeElapsed += Time.deltaTime;

            // Update the current opacity
            currentOpacity = Mathf.Lerp(currentOpacity, targetOpacity, fadeTime * Time.deltaTime);

            // Set the new color of the game object
            spaceBarButton.color = new Color(spaceBarButton.color.r, spaceBarButton.color.g, spaceBarButton.color.b, currentOpacity);

            // Check if the delay time has elapsed
            if (timeElapsed >= delayTime)
            {
                // Update the target opacity to 0
                targetOpacity = 0f;

                // Update the current opacity
                currentOpacity = Mathf.Lerp(currentOpacity, targetOpacity, fadeTime * Time.deltaTime);

                // Set the new color of the game object
                spaceBarButton.color = new Color(spaceBarButton.color.r, spaceBarButton.color.g, spaceBarButton.color.b, currentOpacity);

                // Check if the opacity has reached 0
                if (currentOpacity <= 0f)
                {
                    // Deactivate the game object
                    isActive = false;
                }
            }
        }
    }

    // This method is called when the game object is activated
    public void Activate()
    {
        // Update the target opacity to 1
        targetOpacity = 1f;

        // Reset the time elapsed
        timeElapsed = 0f;

        // Activate the game object
        isActive = true;
    }
}