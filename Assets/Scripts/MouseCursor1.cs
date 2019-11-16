using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Screen.lockCursor = true;
        Screen.lockCursor = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.position = cursorPos;
        Vector2 sensitivity = new Vector2(.05f, .05f);
        //Vector2 mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivity.x, Input.GetAxisRaw("Mouse Y") * sensitivity.y);
        Vector2 mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivity.x, Input.GetAxisRaw("Mouse Y")*sensitivity.y);
        //console.log(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        //Debug.Log(mouseMovement);
        transform.Translate(mouseMovement.x,mouseMovement.y, 0, Space.Self);
    }
}
