using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    bool moveAllowed = false;

    void OnMouseDown()
    {
        Debug.Log("MouseDown");
        moveAllowed = true;

    }
    private void OnMouseDrag()
    {
        if (moveAllowed)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x, transform.position.y);

        }
    }
    private void OnMouseUp()
    {
        moveAllowed = false;
        Debug.Log("ssdsa");
    }
}
