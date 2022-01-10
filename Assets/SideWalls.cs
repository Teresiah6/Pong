using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideWalls : MonoBehaviour
{

    AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Ball")
        {
            var WallName = transform.name;
            GameManager.Score(WallName);
            audioSource.Play();
            collision.gameObject.SendMessage("ResetBall");
        }
    }
}
