using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherScene : MonoBehaviour  
{
    public void startGame(string name) //con estas lineas conseguimos que al precionar el boton start nos lleve al juego
    {
        SceneManager.LoadScene(name);
        AudioManager.instance.ClearAudioList();
    }
    public void Exit() // ESTAS LINEAS DE CODIGO SE USARIAN EN EL BOTON DE SALIDA PARA SALIR DEL JUEGO 
    {
        Application.Quit();
    }
}
