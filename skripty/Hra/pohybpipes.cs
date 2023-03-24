using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pohybpipes : MonoBehaviour
{
    public float rychlostpohybu = 5;
    //public float mimoobraz = -40;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // vynasobit time.deltatime - docs.unity - muze bezet na jinem zarizeni jinou rychlosti
        transform.position = transform.position + (Vector3.left * rychlostpohybu) * Time.deltaTime;

        // smazani pipes ktere jsou mimo obrazovku
        if (transform.position.x < -80)
        {
            Destroy(gameObject);
        }
    }
}
