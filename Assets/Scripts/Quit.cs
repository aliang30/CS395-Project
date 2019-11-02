using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public void doQuit()
	{
		Debug.Log("Has quit game");
		Application.Quit();
	}
}
