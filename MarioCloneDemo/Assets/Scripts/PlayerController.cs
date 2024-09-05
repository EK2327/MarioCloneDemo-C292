using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    private int jumpsLeft = 2;
    private float startingX;
    private float startingY;
    
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingX = transform.position.x;
        startingY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetButtonDown("Jump") && jumpsLeft > 0)
        {
            Jump();
            jumpsLeft -= 1;
        }
    }

    private void Move() 
    {
        float moveInput = Input.GetAxis("Horizontal");
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void Jump() 
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jumpsLeft = 2; 
        }

        if(collision.gameObject.tag == "Enemy")
        {
            transform.position = new Vector3(startingX, startingY, 0);
        }
    }
}
