using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBunny : MonoBehaviour
{
   public float speed;

   private Rigidbody2D rb2D;

   private Vector2 moveVelocity;

   public int carrotNumber;

   public TextMeshProUGUI carrotText;




   void Start()
   { 
       rb2D = gameObject.GetComponent<Rigidbody2D>();

       carrotNumber = 0;

       updateCarrotNumber();



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

   public void collectCarrot(int totalCarrots)
   {
       carrotNumber += totalCarrots;
   }

   public void updateCarrotNumber()
   {
       carrotText.text = "Carrots Collected: " + carrotNumber.ToString ();
   }



}