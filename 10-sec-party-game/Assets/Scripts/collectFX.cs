using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectFX : MonoBehaviour
{
   
   //private PlayerBunny Player;

   public AudioSource collectSFX;
   


    /*void Start()
    {
        Player = FindObjectOfType<PlayerBunny> ();
    }*/


    void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Player")
       {
           collectSFX.Play();
           
       }
       
   }
}