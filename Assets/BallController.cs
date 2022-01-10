using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
   public Rigidbody2D rigidbody2d;
   public int ballSpeed = 10;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float velX = rigidbody2d.velocity.x;
        //monitor x velocity
        Debug.Log("Velocity " + velX);
        if(velX< 8 && velX > -8 && velX !=0)
        {
            //is it tarvelling to left or right
            if(velX > 0)
            {
                rigidbody2d.velocity= new Vector2(10, 0);

            }
            else
            {
                rigidbody2d.velocity = new Vector2(-10, 0);
            }


            Debug.Log("Velocity Before " + velX);
            Debug.Log("Velocity After" + rigidbody2d.velocity);
        }


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            //Debug.Log("IT'S WORKING");
            var velY = rigidbody2d.velocity.y / 2 + collision.collider.attachedRigidbody.velocity.y / 3;
            //velY = rigidbody2d.velocity.y / 2 + collision.collider.attachedRigidbody.velocity.y / 3;
            audioSource.pitch = Random.Range(0.8f, 1.2f);
            audioSource.Play();
        }
    }
    public void ResetBall()
    {
        //reset velocity and position
        rigidbody2d.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0,0);
        StartCoroutine(GoBall());
    }
    public IEnumerator GoBall()
    {
        yield return new WaitForSeconds(2);
        var randomNumber = Random.Range(0, 2);
        if (randomNumber <= 0.5)
        {
            rigidbody2d.AddForce(new Vector2(ballSpeed, 10));
        }
        else
        {
            rigidbody2d.AddForce(new Vector2(-ballSpeed, -10));
        }
    }
}
