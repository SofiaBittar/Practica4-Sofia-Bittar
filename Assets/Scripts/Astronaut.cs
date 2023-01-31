using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Astronaut : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    public float saltoVelocity;
    public SueloChecker checker;
    public float rayDistance = 1.5f;
    public bool IsGrounded;
    public float jumpForce=5f;
    int hopLimit = 1;
    


    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>(); //busca referencia dentro del astronauta
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-10, 0, 0);
          
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(10, 0, 0);
            
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
            
        }

        if (Input.GetKeyDown(KeyCode.Space)) //( && checker.IsGrounded())
        {
            // rb.velocity = new Vector3(rb.velocity.x, saltoVelocity,0);
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }


} 
