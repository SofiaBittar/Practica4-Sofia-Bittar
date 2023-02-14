using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Awards : MonoBehaviour // Cada que agarre un premio suma puntos 
{
    [SerializeField] private float awardsNumber;
    public AudioClip awardsSound;
    [Range(0, 1)]
    public float awardsVolume;
   
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Astronaut")) //busca infromacion dentro del astronauta 
     
        {
            AudioManager.instance.PlayAudioOnLoop(awardsSound, awardsVolume); // activa el audio 
            GameManager.instance.AddPunt(awardsNumber); // el gamemanager instancia la variable de puntos y cada que agarre un premio suma  
            GetComponent<SpriteRenderer>().enabled = false;
            
        }
    }
}
