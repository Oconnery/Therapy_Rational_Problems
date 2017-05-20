using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressButton : MonoBehaviour
{
    //public GameObject anim; 
    float Distance = PlayerCast.distanceFromTarget;
    public GameObject button;

    public Material[] buttonMaterial1; //Material array
    public Renderer rend1;
    private Text Disp;  //UI TEXT

    void Start()
    {
        rend1 = GetComponent<Renderer>();
        rend1.enabled = true; // just incase it's disabled for some reason
        rend1.sharedMaterial = buttonMaterial1[0]; //material starts off at mat 0
        Disp = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update ()
    {
        if (Puzzle1Script.currentlyWrong == true && rend1.sharedMaterial!= buttonMaterial1[0]) //will be true until the player clicks another button which is in the correct order
        {
            
                rend1.sharedMaterial = buttonMaterial1[0]; // reset mat to default
                print("Update1, changetoGrey");
        }
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
                    GetComponent<Animation>().Play("Press1");
                    GetComponent<AudioSource>().Play();

                    print("Button1Pressed");

                    Puzzle1Script.Button1Pressed();

                    if (Puzzle1Script.order ==1)
                    {
                        print("1toBlue");
                        rend1.sharedMaterial = buttonMaterial1[1]; // blue
                    }
            }
        }
        else if (Distance > 5)
        {
            Disp.text = "";
        }
    }
    private void OnMouseExit()
    {
        Disp.text = "";
    }
}
