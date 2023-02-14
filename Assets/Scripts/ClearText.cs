using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearText : MonoBehaviour // hace que se reinicie el contador de la puntuacion 
{
    public TMPro.TMP_Text punctuationText;

    void Update()
    {
        punctuationText.text = "Punctuation: " + GameManager.instance.GetPunt();
    }
}
