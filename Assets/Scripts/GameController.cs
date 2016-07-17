using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
	public bool gameActive;
	public GameObject loseRender;
	public GameObject winRender;

	public void Awake ()
	{
		gameActive = true;
	}

	public void Lose ()
	{
		gameActive = false;
		loseRender.SetActive(true);
	}

	public void Win ()
	{
		gameActive = false;
		winRender.SetActive(true);
	}

	public void LoadNextLevel ()
	{
		int scene = SceneManager.GetActiveScene().buildIndex + 1;
		print(scene);
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}

	public void Restart ()
	{
		int scene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(scene, LoadSceneMode.Single);
	}
}
