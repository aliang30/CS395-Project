using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
	private SpriteRenderer rend;
	public Sprite handCursor;
	public Sprite normalCursor;
	
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
		rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = cursorPos;
		
		if (Input.GetMouseButtonDown(0)){
			rend.sprite = handCursor;
			Vector2 sensitivity = new Vector2(.005f, .005f);
			Vector2 mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivity.x, Input.GetAxisRaw("Mouse Y") * sensitivity.y);

			//console.log(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
			//Debug.Log(mouseMovement);
			transform.Translate(mouseMovement.x,mouseMovement.y, 0, Space.Self);
		} 
		else if (Input.GetMouseButtonUp(0)){
			rend.sprite = normalCursor;
		}
      
    }
}
