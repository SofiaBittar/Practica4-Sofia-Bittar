using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearTime : MonoBehaviour //sirve para limpiar el tiempo 
{
    public TMPro.TMP_Text timeText;

    void Update()
    {
        timeText.text = "Time:" + GameManager.instance.GetTime().ToString("0.00");

    }
}
