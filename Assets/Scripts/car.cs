﻿
using UnityEngine;

public class car : MonoBehaviour {
    public Rigidbody2D rb;

    public float minSpeed = 8f;
    public float maxSpeed = 12f;

    float speed = 1f;

    void Start ()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        Destroy(gameObject, 3f);
    }

    void FixedUpdate() {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
            rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
    }

   // void DestroyObjectDelayed()
  //  {
        // Kills the game object in 5 seconds after loading the object
     //   Destroy("Car", 5);
  //  }
}
