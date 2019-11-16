using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(BoxCollider2D))]

public class Drag : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;
    private bool canMove = true;
    private SpriteRenderer sprite;
    public GameObject level;
    public nextLevel script;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        level = GameObject.Find("Level");
        script = level.GetComponent<nextLevel>();
    }

    void OnMouseDown() 	//void OnMouseOver()
    { 
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    //void OnMouseOver()
    {
        if (canMove == true)
        {
            script.startClock();
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            //Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            //transform.position = curPosition;
			Vector2 sensitivity = new Vector2(.005f, .005f);
			Vector2 mouseMovement = new Vector2(Input.GetAxisRaw("Mouse X") * sensitivity.x, Input.GetAxisRaw("Mouse Y")*sensitivity.y);
			transform.Translate(mouseMovement.x,mouseMovement.y, 0, Space.Self);
            sprite.sortingOrder = 4;
        }
    }

    private void OnTriggerEnter2D(Collider2D EmptySquare)
    {
        float y = EmptySquare.gameObject.GetComponent<Rigidbody2D>().position.y;
        float x = EmptySquare.gameObject.GetComponent<Rigidbody2D>().position.x;
        if (EmptySquare.gameObject.tag == "EmptySquare")
        {
            canMove = false;
            sprite.sortingOrder = 3;
            transform.position = new Vector3(x, y, 0);
            script.next();
        }
        else
        {
            canMove = true;
        }
    }
}
