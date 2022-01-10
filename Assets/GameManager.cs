using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore01 = 0, playerScore02 = 0;
    public GUISkin theSkin;
    Transform theball;
    // Start is called before the first frame update
    private void Start()
    {
        theball = GameObject.FindGameObjectWithTag("Ball").transform;
    }
    public static void Score(string wallName)
    {
        if(wallName == "rightWall")
        {
            playerScore01++;
        }
        else
        {
            playerScore02++;
        }
        Debug.Log("Player score 1 is " + playerScore01);
        Debug.Log("Player score 2 is " + playerScore02);
    }

    void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width / 2 - 150-12, 25, 100, 100), "" + playerScore01);
        GUI.Label(new Rect(Screen.width / 2 + 150-12, 25, 100, 100), "" + playerScore02);


        if(GUI.Button (new Rect (Screen.width/2 -121/2, 35,121,53), "RESET"))
        {
            //reset score
            playerScore01 = 0;
            playerScore02 = 0;
            theball.gameObject.SendMessage("ResetBall");
        }
    }


}
