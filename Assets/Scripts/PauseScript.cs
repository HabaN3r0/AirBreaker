using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour {

    public Canvas pauseMenu;
    public Canvas settingsMenu;
    public Canvas pauseCanvas;
    public Button pauseButton;
    public Button continueButton;
    public Button settingsButton;
    public Button quitButton;
    public Button exitButton;

    void Start () {
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        settingsMenu = settingsMenu.GetComponent<Canvas>();
        pauseCanvas = pauseCanvas.GetComponent<Canvas>();
        pauseButton = pauseButton.GetComponent<Button>();
        continueButton = continueButton.GetComponent<Button>();
        settingsButton = settingsButton.GetComponent<Button>();
        quitButton = quitButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();

        pauseMenu.enabled = false;
        settingsMenu.enabled = false;
    }

    void onMouseDown()
    {
        Time.timeScale = 0;
        pauseMenu.enabled = true;
    }

    public void continuePress()
    {
        pauseMenu.enabled = false;
        Time.timeScale = 1;
    }

    public void settingsPress()
    {
        settingsMenu.enabled = true;
    }

    public void sClosePress()
    {
        settingsMenu.enabled = false;
    }

    public void pClosePress()
    {
        pauseMenu.enabled = false;
        SceneManager.LoadScene(0);
    }
    
}