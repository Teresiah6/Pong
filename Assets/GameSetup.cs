using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
   public Camera mainCamera;
   public BoxCollider2D topWall, bottomWall, leftWall, rightWall;
   public Transform player01, player02;

    // Update is called once per frame
    void Update()
    {
        topWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width*2f,0f, 0f)).x,1f);
        topWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        bottomWall.size = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).y - 0.5f);

        leftWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(0f, 0f, 0f)).x - 0.5f, 0f);

        rightWall.size = new Vector2(1f, mainCamera.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

        //Move the players to a fixed distance from the edges of the screen:
        player01.position.Set(mainCamera.ScreenToWorldPoint(new Vector3(50f, 0f, 0f)).x, 0f, 0f);
        player02.position.Set(mainCamera.ScreenToWorldPoint(new Vector3(Screen.width - 50f, 0f, 0f)).x, 0f, 0f);
    }
}
