using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkoreScript : MonoBehaviour
{
    public int Skore;
    public Text SkoreText;
    public GameObject Konec;

    [ContextMenu("Prosel Pipes")]
    public void ProselPipes(int Odmena)
    {
        //Pridej Skore a Zapis to do Textoveho pole
        Skore = Skore + Odmena;
        SkoreText.text = Skore.ToString();
    }

    //Zacneme znova na Scene Hra, ta je aktivni takze staci znova nacist activni session
    public void Zacitznova()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //Zviditelnit Screen Konec Hry, na toto se chytne Peng Script - pri narazu je potreba zviditelnit
    public void KonecHry()
    {
        Konec.SetActive(true);
    }
}
