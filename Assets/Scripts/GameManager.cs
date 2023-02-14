using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private float punctuation = 0;
    private float time = 0;
    public  AudioClip bellSound;
    public float bellVolume;
    // Start is called before the first frame update
    void Awake()
    {
        if (!instance) // esto revisa que sea el unico  y  en tal caso que haya otro el condicional se encarga de destruirlo 
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // se utiliza 
        if(time % 5 == 0)
        {
            AudioManager.instance.PlayAudio(bellSound, bellVolume);
        }
    }
    public void AddPunt(float value)
    {
        punctuation += value;
    }
    public float GetPunt()
    {
        return punctuation;
    }
    public float GetTime()
    {
        return time;
    }
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
        AudioManager.instance.ClearAudioList();
    }
}
