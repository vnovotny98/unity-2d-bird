using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkoreScript : MonoBehaviour
{
    public int Skore;
    public Text SkoreText;

    [ContextMenu("Prosel Pipes")]
    public void ProselPipes(int Odmena)
    {
        //Pridej Skore a Zapis to do Textoveho pole
        Skore = Skore + Odmena;
        SkoreText.text = Skore.ToString();
    }
}
