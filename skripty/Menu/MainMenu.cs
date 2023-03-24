using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void TlacKonec()
    {
        Application.Quit();
    }
    public void Hrat()
    {
        SceneManager.LoadScene("Game");
    }
}
