using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pengscript : MonoBehaviour
{
    public float Sila;
    public Rigidbody2D mujrigid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true )
        mujrigid.velocity = Vector2.up * Sila;
    }
}
