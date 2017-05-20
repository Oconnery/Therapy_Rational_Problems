using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PressButton5 : MonoBehaviour
{
    //public GameObject anim; 
    float Distance = PlayerCast.distanceFromTarget;
    public GameObject button;

    public Material[] buttonMaterial5; //Material array
    public Renderer rend5;
    private Text Disp;  //UI TEXT


    void Start()
    {
        rend5 = GetComponent<Renderer>();
        rend5.enabled = true; // just incase it's disabled for some reason
        rend5.sharedMaterial = buttonMaterial5[0]; //material starts off at mat 0
        Disp = GameObject.Find("Text").GetComponent<Text>();
    }

    void Update ()
    {
        if (Puzzle1Script.currentlyWrong == true && rend5.sharedMaterial != buttonMaterial5[0]) //will be true until the player clicks another button which is in the correct order
        {
            rend5.sharedMaterial = buttonMaterial5[0]; // reset mat to default
            print("Update5, changetoGrey");
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
                GetComponent<Animation>().Play("1Press5");
                GetComponent<AudioSource>().Play();

                print("Button5Pressed");

                Puzzle1Script.Button5Pressed();

                if (Puzzle1Script.order == 4)
                {
                    rend5.sharedMaterial = buttonMaterial5[1]; // blue
                    print("5toBlue");
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
