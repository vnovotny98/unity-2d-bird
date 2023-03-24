using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProselPipesScript : MonoBehaviour
{
    public SkoreScript logic;
    // Start is called before the first frame update
    void Start()
    {
        //Pripojeni logy ze peng prosel pipes s jinym skriptem pomoci kodu - proselpipes script reference na Skore Script
        logic = GameObject.FindGameObjectWithTag("SkoreManTag").GetComponent<SkoreScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // funkce OnTrigger, pokazde kdyz projde trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Nastavil jsem novy layer na pengovi, layer3
        if (collision.gameObject.layer == 3)
        {
            //Nastav funkci ProselPipes Odmenu 10
            logic.ProselPipes(10);
        }
    }
}
