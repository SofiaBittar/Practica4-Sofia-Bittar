using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int punctuation = 0;
    private float time = 0;
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
    }
    public void AddPunt(int value)
    {
        punctuation += value;
    }
    public int Getpunt()
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
    }
}
