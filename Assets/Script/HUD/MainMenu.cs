using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject loadAGame;
    public GameObject settingsWindow;
    public GameObject controlsBoard;
    public GameObject audioBoard;
    public GameObject graphicBoard;
    public GameObject creditsWindow;
    public GameObject QuitGameButton;

    public void Play()
    {
        SceneManager.LoadScene("Intro");
    }

    public void CloseLoadAGame()
    {
        loadAGame.SetActive(false);
    }
    public void Options()
    {
        settingsWindow.SetActive(true);
        controlsBoard.SetActive(true);
    }

    public void CloseSettingsWindow()
    {
        settingsWindow.SetActive(false);

        audioBoard.SetActive(false);
        graphicBoard.SetActive(false);
    }
    public void ControlsBoard()
    {
        settingsWindow.SetActive(true);
        audioBoard.SetActive(false);
        graphicBoard.SetActive(false);
        controlsBoard.SetActive(true);
    }
    public void AudioBoard()
    {
        settingsWindow.SetActive(true);
        audioBoard.SetActive(true);
        graphicBoard.SetActive(false);
        controlsBoard.SetActive(false);
    }
    public void GraphicBoard()
    {
        settingsWindow.SetActive(true);
        audioBoard.SetActive(false);
        graphicBoard.SetActive(true);
        controlsBoard.SetActive(false);
    }

    public void Credits()
    {
        creditsWindow.SetActive(true);
    }

    public void CloseCreditsWindow()
    {
        creditsWindow.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
