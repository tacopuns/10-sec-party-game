using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrotPickUp : MonoBehaviour
{

    private PlayerBunny Player;

    public int scoreValue;

    void Start()
    {
        Player = FindObjectOfType<PlayerBunny> ();
    }
   
   
   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.tag == "Player")
       {
           Destroy(gameObject);
           Player.collectCarrot(scoreValue);
       }
   }


}
