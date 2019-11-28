using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Text.RegularExpressions;

public class nextLevel : MonoBehaviour
{
    public int total;
    public int counter;
    Scene m_Scene;
    public string nextScene;
    AudioSource audio;
    float start, end;
    public bool once1, once2;
    // Start is called before the first frame update

    IEnumerator Music()
    { 
        yield return new WaitForSeconds(6);
        once1 = true;
        once2 = true;
        SceneManager.LoadScene(nextScene);
    }

    void Start()
    {

        total = GameObject.FindGameObjectsWithTag("Circle").Length + GameObject.FindGameObjectsWithTag("Square").Length + GameObject.FindGameObjectsWithTag("Rect").Length +
        GameObject.FindGameObjectsWithTag("Green").Length + GameObject.FindGameObjectsWithTag("Yellow").Length + GameObject.FindGameObjectsWithTag("Red").Length;
        m_Scene = SceneManager.GetActiveScene();
        string cur_name = m_Scene.name;
        string num = Regex.Match(cur_name, @"\d+").Value;
        Int32.TryParse(num, out int sceneNum);
        int newScene = sceneNum + 1;
        string newNum = newScene.ToString();
		
		//if first letter begins with a 'l'
        if (cur_name[0] == 'l')
        {
            nextScene = "left_" + newNum;
        }
		
		//if first letter begins with a 'r'
        else if (cur_name[0] == 'm')
        {
            nextScene = "middle_" + newNum;
        }
		else 
		{
			nextScene = "right_" + newNum;
		}
		
        if ((cur_name == "middle_20") || (cur_name == "left_20") || (cur_name == "right_20"))
        {
            nextScene = "Start";
        }
		
        counter = 0;
        audio = GetComponent<AudioSource>();
        once1 = true;
        once2 = true;
        audio.Play(0);
        audio.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == total)
        {
            if(once2 == true)
           {
                endClock();
            }
            audio.UnPause();
            StartCoroutine(Music());
        }
        ////DEBUG
        //Level Skip Cheat
        if (Input.GetKeyDown("space")) {
            SceneManager.LoadScene(nextScene);
        }
        ////
    }

    public void startClock()
    {
        //Debug.Log("here");
        if (once1 == true)
        {
            start = Time.time;
            once1 = false;
        }
    }

    public void endClock()
    {
        end = Time.time;
        Debug.Log("Time to complete: " + (end - start));
        //Debug.Log("start = " + start + " end = " + end);
        //Debug.Log(start);
        once2 = false;
    }

    public void next()
    {
        counter++;
    }
}
