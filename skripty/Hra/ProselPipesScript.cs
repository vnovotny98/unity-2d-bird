using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProselPipesScript : MonoBehaviour
{
    public SkoreScript TriggerSkore;
    // Start is called before the first frame update
    void Start()
    {
        TriggerSkore = GameObject.FindGameObjectWithTag("ReferencezProsel").GetComponent<SkoreScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // funkce OnTrigger, pokazde kdyz projde trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
            TriggerSkore.ProselPipes();

    }
}
