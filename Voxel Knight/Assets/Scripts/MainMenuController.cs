using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
	public string name;

	public void ChangeScene(string sceneName)
	{
		if (SceneManager.GetActiveScene().name != name)
			SceneManager.LoadScene(name);
		else
			return;
	}
	public void Exit()
	{
		Application.Quit();
	}
}
