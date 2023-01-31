using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillAstronaut : MonoBehaviour  //este codigo se usa para que el enemigo mate al astronauta y a su vez reinicie la escena

{
   
    public float speed = 1.5f;

   private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.GetComponent<Astronaut>())
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene("SampleScene");
        }
    }
    
}

