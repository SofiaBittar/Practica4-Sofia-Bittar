using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherScene : MonoBehaviour
{
    public void startGame(string name)
    {
        SceneManager.LoadScene(name);
    }
}
