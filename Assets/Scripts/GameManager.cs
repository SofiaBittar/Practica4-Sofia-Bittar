using System.Collections;
using System.Collections.Generic;
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
        if (!instance)
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
        time += Time.deltaTime;
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
