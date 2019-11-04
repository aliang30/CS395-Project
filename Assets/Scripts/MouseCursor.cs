using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour {
	Vector2 sensitivity = new Vector2(0.5f, 0.5f);

	
	// Use this for initialization
	void Start () {
		//Hide real cursor
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Confined;
	}
	
	// Update is called once per frame
	void Update () {
		//Create our Cursor
		
		Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		/*Vector2 mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivity.x,
                                    Input.GetAxisRaw("Mouse Y") * sensitivity.y);*/
		transform.position = cursorPos;
		
	}
}
