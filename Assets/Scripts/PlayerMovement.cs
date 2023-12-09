using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float JumpForce = 10;
    [SerializeField] private bool onGround;
    [SerializeField] private Rigidbody2D playerRB;
   
   
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Running();
        Jumping();

    }
   

    public void Running()
    {
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * speed * Time.deltaTime;

    }

    public void Jumping()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRB.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            onGround = true;
        }

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            onGround = false;
        }

     
    }

  
}
