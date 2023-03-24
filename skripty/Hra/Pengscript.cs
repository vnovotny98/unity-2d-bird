using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengScript : MonoBehaviour
{
    public float Sila;
    public Rigidbody2D mujrigid;
    public SkoreScript Naraz;
    public bool PengisLive = true;
    public AudioSource sound2;
    // Start is called before the first frame update
    void Start()
    {
        //Pripojeni logiky ze peng narazil do pipes s jinym skriptem pomoci kodu - pengscript  reference na Skore Script
        Naraz = GameObject.FindGameObjectWithTag("SkoreManTag").GetComponent<SkoreScript>();

    }

    // Update is called once per frame
    void Update()
    {
        //pri stisknuti enteru zvednout penga
        if (Input.GetKeyDown(KeyCode.Space) == true && PengisLive == true )
        {
            mujrigid.velocity = Vector2.up * Sila;
            sound2.Play();
        }
    }
    //pri colisi penga pouzit funkci KonecHry z SkoreScriptu
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Naraz.KonecHry();
        PengisLive = false;
    }
}
