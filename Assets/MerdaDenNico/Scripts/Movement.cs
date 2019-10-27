using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 thurst;
    //public float moveSpeed = 5f;
    public bool isGrounded;
    public float jumpForce;
    public bool isJumping;
    public float jumpTimer;
    public float jumpTimerCounter;
    public float velocitat;
    public LayerMask groundLayers;
    // Start is called before the first frame update
    void Start()
    {
        //thurst = new Vector2(1,0);
        rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(thurst, ForceMode2D.Force);
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed;
        //Vector2 nw = new Vector2(1,-1);
        float v2 = rb.velocity.y;
        rb.velocity = new Vector2(velocitat, v2);
        //isGrounded = groundChecker.isGrounded;
        
            
        //Debug.Log(isGrounded);
        
    }

    void Jump() {
        if (Input.GetMouseButtonDown(0) && isGrounded == true) {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
            jumpTimerCounter = jumpTimer; 
        } 

        if (Input.GetMouseButton(0) && isJumping == true) {
            if (jumpTimerCounter > 0) {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
                jumpTimerCounter -= Time.deltaTime;
            } else {
                isJumping = false;
            }
        }

        if (Input.GetMouseButtonUp(0)) {
            isJumping = false;
        }
        //Debug.Log(rb.velocity.y);
        if (rb.velocity.y < 0f) {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y - 0.3f);
        }
    }
}
