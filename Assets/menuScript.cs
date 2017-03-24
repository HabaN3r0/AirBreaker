using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
    public Canvas settingsMenu;
	public Button startText;
	public Button exitText;
    public Button closeText;
	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
        settingsMenu = settingsMenu.GetComponent<Canvas>();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
        closeText = closeText.GetComponent<Button>();
		quitMenu.enabled = false;
        settingsMenu.enabled = false;
	}
	
	public void ExitPress(){
		quitMenu.enabled = true;
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress(){
		quitMenu.enabled = false;
		startText.enabled = true;
		exitText.enabled = true;
	}

    public void SettingsPress()
    {
        settingsMenu.enabled = true;
    }

    public void SettingsClosed()
    {
        settingsMenu.enabled = false;
    }

	public void StartLevel(){
        SceneManager.LoadScene("SceneName");
	}

	public void ExitGame(){
		Application.Quit();
	}

	// Update is called once per frame
	void Update () {
		
	}
}
