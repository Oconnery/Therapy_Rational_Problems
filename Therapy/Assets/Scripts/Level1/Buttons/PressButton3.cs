using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressButton3 : MonoBehaviour
{
    //public GameObject anim; 
    float Distance = PlayerCast.distanceFromTarget;
    public GameObject button;

    public Material[] buttonMaterial3; //Material array
    public Renderer rend3;
    private Text Disp;  //UI TEXT

    void Start()
    {
        rend3 = GetComponent<Renderer>();
        rend3.enabled = true; // just incase it's disabled for some reason
        rend3.sharedMaterial = buttonMaterial3[0]; //material starts off at mat 0
        Disp = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update ()
    {
        if (Puzzle1Script.currentlyWrong == true && rend3.sharedMaterial != buttonMaterial3[0]) //will be true until the player clicks another button which is in the correct order
        {
            rend3.sharedMaterial = buttonMaterial3[0]; // reset mat to default
            print("Update3, changetoGrey");
        }
    }

    private void OnMouseOver()
    {
        Distance = PlayerCast.distanceFromTarget;
        if (Distance <= 5)
        {
            Disp.text = ("Press Button");
            if (Input.GetButtonDown("Action"))
            {
                GetComponent<GameObject>();
                GetComponent<Animation>().Play("1Press3");
                GetComponent<AudioSource>().Play();

                print("button3Pressed");

                Puzzle1Script.Button3Pressed();

                if (Puzzle1Script.order == 6)
                {
                    rend3.sharedMaterial = buttonMaterial3[1]; // blue
                    print("3toBlue");
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
