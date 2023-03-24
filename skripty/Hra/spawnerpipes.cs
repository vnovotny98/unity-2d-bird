using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerpipes : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float vzdalenostpipes;
    // Start is called before the first frame update
    //prvni pipe spawn
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //casovac pro spawnuti dalsi pipe
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float spodnihranice = transform.position.y - vzdalenostpipes;
        float hornihranice = transform.position.y + vzdalenostpipes;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(spodnihranice, hornihranice), 0), transform.rotation);
    }
}
