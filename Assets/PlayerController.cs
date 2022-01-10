using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public KeyCode moveUp;
    public KeyCode moveDown;
    public float speed = 10.0f;
    private Rigidbody2D rigidBody2D;
    private void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>() as Rigidbody2D;
        rigidBody2D.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if (Input.GetKey(moveUp))
        {
            rigidBody2D.velocity = new Vector2 (0, speed);

        }
        else if (Input.GetKey(moveDown))
        {
            rigidBody2D.velocity = new Vector2(0, -speed);
        }
        else
        {
            rigidBody2D.velocity = new Vector2(0, 0);
        }
    }
}
