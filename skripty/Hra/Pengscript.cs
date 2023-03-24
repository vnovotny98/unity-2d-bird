using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengScript : MonoBehaviour
{
    public float Sila;
    public Rigidbody2D mujrigid;
    public SkoreScript Naraz;
    // Start is called before the first frame update
    void Start()
    {
        //Pripojeni logiky ze peng narazil do pipes s jinym skriptem pomoci kodu - pengscript  reference na Skore Script
        Naraz = GameObject.FindGameObjectWithTag("SkoreManTag").GetComponent<SkoreScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true )
        {
            mujrigid.velocity = Vector2.up * Sila;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Naraz.KonecHry();
    }
}
