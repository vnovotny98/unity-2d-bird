using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PohybPipesScript : MonoBehaviour
{
    public float rychlostpohybu;
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
