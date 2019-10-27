using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

	public float speed = 7f;

	private float input;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        input = Input.GetAxisRaw("Mouse X"); //Not Sure
    }

    private void FixedUpdate() {
    	GetComponent<Rigidbody2D>().velocity = Vector2.right * input * speed;
    }
}
