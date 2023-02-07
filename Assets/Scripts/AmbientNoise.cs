using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientNoise : MonoBehaviour
{
    public AudioClip ambientNoise;
    [Range(0, 1)]
    public float volumeMusic;
    private void Start()
    {
        AudioManager.instance.PlayAudioOnLoop(ambientNoise, volumeMusic);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
