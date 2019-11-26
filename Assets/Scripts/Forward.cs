using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Forward : MonoBehaviour
{
    public Button m_button;
	

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
		int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
		SceneManager.LoadScene(nextScene);
    }
}
