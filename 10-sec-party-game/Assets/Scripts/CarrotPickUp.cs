using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotPickUp : MonoBehaviour
{

    private PlayerBunny Player;

    public int scoreValue;

    public AudioSource collectSFX;
    

    void Start()
    {
        Player = FindObjectOfType<PlayerBunny> ();
        
    }
   
   
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Player")
       {
           Player.collectCarrot(scoreValue);
           Player.updateCarrotNumber();
           collectSFX.Play();
           Destroy(gameObject);
           
       }
       
   }


}
