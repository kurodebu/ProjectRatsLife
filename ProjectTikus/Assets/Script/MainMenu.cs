using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject PauseG;
	public GameObject PauseMenu;
	public void ExitButton() {
		Application.Quit();
		Debug.Log("Game closed");
	}
	
	public void LevelSelect() {
		SceneManager.LoadScene("2.LevelSelect");
	}
	
	public void mainMenu() {
		SceneManager.LoadScene("1.MainMenu");
	}

	public void Pause() {
		Time.timeScale=0;
		PauseG.SetActive(false);
		PauseMenu.SetActive(true);
	}

	public void Resume() {
		Time.timeScale=1;
		PauseG.SetActive(true);
		PauseMenu.SetActive(false);
	}

	public void RestartLevel1() {
		SceneManager.LoadScene("3.Level1");
		Time.timeScale=1;
	}

	public void RestartLevel2() {
		SceneManager.LoadScene("4.Level2");
		Time.timeScale=1;
	}

	public void RestartLevel3() {
		SceneManager.LoadScene("5.Level3");
		Time.timeScale=1;
	}

	public void RestartLevel4() {
		SceneManager.LoadScene("6.Level4");
		Time.timeScale=1;
	}

	public void RestartLevel5() {
		SceneManager.LoadScene("7.Level5");
		Time.timeScale=1;
	}

	public void RestartLevel6() {
		SceneManager.LoadScene("8.Level6");
		Time.timeScale=1;
	}

	public void RestartLevel7() {
		SceneManager.LoadScene("9.Level7");
		Time.timeScale=1;
	}

	public void RestartLevel8() {
		SceneManager.LoadScene("10.Level8");
		Time.timeScale=1;
	}

	public void RestartLevel9() {
		SceneManager.LoadScene("11.Level9");
		Time.timeScale=1;
	}

	public void RestartLevel10() {
		SceneManager.LoadScene("12.Level10");
		Time.timeScale=1;
	}

	
}