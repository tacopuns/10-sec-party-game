using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBunny : MonoBehaviour
{
   public float speed;

   private Rigidbody2D rb2D;

   private Vector2 moveVelocity;

   public int carrotNumber;


   void Start()
   { 
       rb2D = gameObject.GetComponent<Rigidbody2D>();

   }
   void Update()
   {
       Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
       moveVelocity = moveInput.normalized * speed;

   }

   void FixedUpdate ()
   {
       rb2D.MovePosition(rb2D.position + moveVelocity * Time.fixedDeltaTime);
   }

   /*private void OnTriggerEnter(Collider other)
   {
       if (other.tag == "carrotPickup")
       {
           carrotNumber = carrotNumber + 1;
           Destroy(other.gameObject);
       }

       else
       {

       }

       Debug.Log("Carrot" + other);

   }*/

   public void collectCarrot(int totalCarrots)
   {
       carrotNumber += totalCarrots;
   }

}