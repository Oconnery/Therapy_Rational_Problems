using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class laserButton : MonoBehaviour {

   Text Disp;  //UI TEXT
   public static bool laserOff = false;
    float Distance = PlayerCast.distanceFromTarget;

    // Use this for initialization
    void Start () {
        Disp = GameObject.Find("Text").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {

    }

    private void OnMouseOver()
    {
        Distance = PlayerCast.distanceFromTarget;
        if (Distance <= 5) //and the distance between player and object is less than 3 units
        {
            Disp.text = ("Press Button");
            if (Input.GetButtonDown("Action")) //If (player presses E)
            {
                GetComponent<GameObject>();
                GetComponent<Animation>().Play("laserButton1");
                GetComponent<AudioSource>().Play();

                print("Player pressed button");

                //Stop the laser
                laserOff = true;
            }
        }
    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }


}
