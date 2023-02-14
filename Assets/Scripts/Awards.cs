using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awards : MonoBehaviour // Cada que agarre un premio suma puntos 
{
    [SerializeField] private float awardsNumber; 
   
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Astronaut")) 
     
        {
            GameManager.instance.AddPunt(awardsNumber);
            GetComponent<SpriteRenderer>().enabled = false;
            
        }
    }
}
