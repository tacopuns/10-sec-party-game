using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBunny : MonoBehaviour
{
   public float speed;

   private Rigidbody2D rb;

   private Vector2 moveVelocity;

   void Start()
   { 
       rb = GetComponent<Rigidbody2d>();
   }
   void Update()
   {
       Vector2 moveInput = new Vector2(moveInput.GetAxis("Horizontal"), moveInput.GetAxis("Vertical"));
       moveVelocity = moveInput.normalized * speed;

   }

   void FixedUpdate ()
   {
       rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
   }
}