using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class PressButton6 : MonoBehaviour
{
    //public GameObject anim; 
    float Distance = PlayerCast.distanceFromTarget;
    public GameObject button;

    public Material[] buttonMaterial6; //Material array
    public Renderer rend6;
    private Text Disp;  //UI TEXT

    void Start()
    {
        rend6 = GetComponent<Renderer>();
        rend6.enabled = true; // just incase it's disabled for some reason
        rend6.sharedMaterial = buttonMaterial6[0]; //material starts off at mat 0
        Disp = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update ()
    {
        if (Puzzle1Script.currentlyWrong == true && rend6.sharedMaterial != buttonMaterial6[0]) //will be true until the player clicks another button which is in the correct order
        {
            rend6.sharedMaterial = buttonMaterial6[0]; // reset mat to default
            print("Update6, changetoGrey");
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
                GetComponent<Animation>().Play("1Press6");
                GetComponent<AudioSource>().Play();

                print("Button6Pressed");

                Puzzle1Script.Button6Pressed();

                if (Puzzle1Script.order == 5)
                {
                    rend6.sharedMaterial = buttonMaterial6[1]; // blue
                    print("6toBlue");
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
