using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
    public Canvas settingsMenu;
    public Canvas gameMenu;
    //public Canvas  diffMenu;
	public Button startText;
	public Button exitText;
    public Button closeText;
   // public Button typeText;
    //public Button vibOn;
    //public Button vibOff;
    public Slider musicSlider;
    public bool checkVib = false;
    // public AudioListener backSound;
	// public float VolumeSliderValue = 0.6f;
	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
        settingsMenu = settingsMenu.GetComponent<Canvas>();
        gameMenu = gameMenu.GetComponent<Canvas>();
        //diffMenu = diffMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
        closeText = closeText.GetComponent<Button>();
       // typeText = typeText.GetComponent<Button>();
        //vibOn = vibOn.GetComponent<Button>();
        //vibOff = vibOff.GetComponent<Button>();
        musicSlider = musicSlider.GetComponent<Slider>();
        quitMenu.enabled = false;
        settingsMenu.enabled = false;
        gameMenu.enabled = true;
       // diffMenu.enabled = false;
	}
	
	public void ExitPress(){
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
		gameMenu.enabled = false;
	}

	public void NoPress(){
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
		gameMenu.enabled = true;
	}

    public void SettingsPress()
    {
        settingsMenu.enabled = true;
        gameMenu.enabled = false;
    }

    public void SettingsClosed()
    {
        settingsMenu.enabled = false;
        gameMenu.enabled = true;
    }

    public void ChooseMode(){
      //  gameMenu.enabled = true;
        //diffMenu.enabled = false;
    }

    public void ChooseGame()
    {
       // diffMenu.enabled = true;
    }

    public void LeaveMode()
    {
      //  diffMenu.enabled = false;
      //  gameMenu.enabled = false;
    }

	public void StartLevel(){
        SceneManager.LoadScene("MiniGame");
	}

	public void ExitGame(){
		Application.Quit();
	}

    public void setMusic()
    {
    	AudioListener.volume = musicSlider.value/10;
    }
	// Update is called once per frame
	void Update () {

    }
}
