using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

  private float speed = 10f;
  private Rigidbody2D mBody;
    // Start is called before the first frame update
    void Awake()
    { 
        mBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Vector2 velocity = mBody.velocity;
      velocity.x = Input.GetAxis("Horizontal") * speed;
      mBody.velocity = velocity;
    }
}//class
