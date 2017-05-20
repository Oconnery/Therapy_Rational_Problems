using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PressButton2 : MonoBehaviour
{
    //public GameObject anim; 
    float Distance = PlayerCast.distanceFromTarget;
    public GameObject button;

    public Material[] buttonMaterial2; //Material array
    public Renderer rend2;
    private Text Disp;  //UI TEXT

    void Start()
    {
        rend2 = GetComponent<Renderer>();
        rend2.enabled = true; // just incase it's disabled for some reason
        rend2.sharedMaterial = buttonMaterial2[0]; //material starts off at mat 0
        Disp = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update ()
    {
        if (Puzzle1Script.currentlyWrong == true && rend2.sharedMaterial != buttonMaterial2[0]) //will be true until the player clicks another button which is in the correct order
        {
            rend2.sharedMaterial = buttonMaterial2[0]; // reset mat to default
            print("Update2, changetoGrey");
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
                 GetComponent<Animation>().Play("Press2");
                 GetComponent<AudioSource>().Play();
                 // print("Pressing");

                 print("Button2Pressed");
            
                 Puzzle1Script.Button2Pressed();
           
                 if (Puzzle1Script.order == 2)
                 {
                     rend2.sharedMaterial = buttonMaterial2[1]; // blue
                     print("2toBlue");
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