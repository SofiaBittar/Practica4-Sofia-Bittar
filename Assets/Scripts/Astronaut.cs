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
    public LayerMask mascaraSuelo;
    public GameObject camara;
    public AudioClip jumpSound;
    [Range(0, 1)]
    public float jumpVolume;
    public AudioClip deadslimeSound;
    [Range(0, 2)]
    public float deadslimeVolume;


    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>(); //busca referencia dentro del astronauta
        mascaraSuelo = LayerMask.NameToLayer("Suelo");
    }

    // Update is called once per frame
    void Update()
    {
        Raycast();
        Camerafollow();
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector3(-10, rb.velocity.y, 0);
            GetComponent<SpriteRenderer>().flipX = true; // se utiliza para que la animacion gire dependiendo a que lado se mueva 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector3(10, rb.velocity.y, 0);
            GetComponent<SpriteRenderer>().flipX = false; // se utiliza para que la animacion gire dependiendo a que lado se mueva 

        }
        else
        {
           // rb.velocity = new Vector3(0, 0, 0);
            
        }

        if (Input.GetKeyDown(KeyCode.Space)  && IsGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, saltoVelocity,0);
            AudioManager.instance.PlayAudio(jumpSound, jumpVolume);
        }

        if (transform.position.y <= -6.36f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
    void OnDrawGizmosSelected() // se emplean para que sea visible el rayo que sale a traves del personaje 
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector2.down * rayDistance);
    }

    void Raycast() // con este codigo se utiliza para que el astronauta salte cuando sea suelo  
    {
        RaycastHit2D resultado = Physics2D.Raycast(transform.position,
             Vector2.down, rayDistance, mascaraSuelo.value);
        IsGrounded = resultado.collider;
    }
       
    void Camerafollow() //se utiliza para que la camara siga al astronauta en los distintos ejes 
    {
        camara.transform.position = new Vector3(transform.position.x, camara.transform.position.y, camara.transform.position.z);
    }
    private void OnTriggerEnter2D(Collider2D other) //se utiliza para que cuando el astronauta salte arriba del slime lo mate 
    {
        if(other.CompareTag("DeadSlime"))
        {
            Destroy(other.transform.parent.gameObject);
            AudioManager.instance.PlayAudio(deadslimeSound, deadslimeVolume);
        }

    }
} 
