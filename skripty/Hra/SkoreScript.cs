using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkoreScript : MonoBehaviour
{
    public int Skore;
    public Text SkoreText;

    [ContextMenu("Prosel Pipes")]
    public void ProselPipes()
    {
        Skore = Skore + 1;
        SkoreText.text = Skore.ToString();
    }
}
