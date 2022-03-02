using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	
	public void ExitButton() {
		Application.Quit();
		Debug.Log("Game closed");
	}
	
	public void StartGame() {
		SceneManager.LoadScene("tutorial");
	}
	
	public void StartGame2() {
		SceneManager.LoadScene("Level1");
	}
	
	public void BacktoMain() {
		SceneManager.LoadScene("MainMenu");
	}
	
	public void GotoCredits() {
		SceneManager.LoadScene("credit");
	}
	
	
}