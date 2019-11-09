using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockCursor : MonoBehaviour
{
	void Start() {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
    // Update is called once per frame
    void Update()
    {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
		
		if (Input.GetKeyDown("2")) {
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
    }
}
