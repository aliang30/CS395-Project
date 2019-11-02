using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void SceneLoader(int SceneIndex)
	{
		Debug.Log("Success");
		SceneManager.LoadScene(SceneIndex);
	}
}
