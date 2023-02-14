using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherScene : MonoBehaviour //nos lleva a la escena 
{
    public void startGame(string name)
    {
        SceneManager.LoadScene(name);
    }
}
