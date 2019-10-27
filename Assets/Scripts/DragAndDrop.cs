using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    bool moveAllowed;

void OnMouseDown() {
       Debug.Log("MouseDown");
       moveAllowed = true;
         
   }
   private void OnMouseDrag() {
       if (moveAllowed) {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x, mousePosition.y);
          
       }
   }
   private void OnMouseUp() {
           moveAllowed = false;     
   }
}