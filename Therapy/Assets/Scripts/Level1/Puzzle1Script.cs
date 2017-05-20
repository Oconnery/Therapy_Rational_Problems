using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Script: MonoBehaviour {

    //ORDER OF BUTTONS = 1,2,4,5,6,3

    // Use this for initialization
    public static bool button1, button2, button3, button4, button5, button6, buzz;
    public static int order = 0;

    public static bool currentlyWrong = false;

    void Start ()
    {
        //Oisin - Adding in a point light to see how this works out (1 point light for all of the buttons)
    }

	void Update ()
    {
        if (button1 == true && button2 == true && button3 == true && button4 == true && button5 == true && button6 == true )
        {
            DoorOpen.Open();
            PointLight1.light.color = Color.blue;

            //Disable buttons - anims and sounds

            // Change lighting? 
            //Buttons perhaps flicker a light 
            // Or/and the room lighting increases 
        }

        if (buzz == true)
        {
            GetComponent<AudioSource>().Play();
            buzz = false; 
        }
    }

    public static void Clear()
    {
        button1 = false;
        button2 = false;
        button3 = false;
        button4 = false;
        button5 = false;
        button6 = false;
        buzz = true;
        order = 0;

        currentlyWrong = true; //player just hit an incorrect button

        // add in here - rest all of the buttons to grey

        //GameObject.Find("Button1").GetComponent<PressButton>().rend.sharedMaterial = PressButton.buttonMaterial[0]; //buttonMaterial[0];
        //GameObject.Find("Button2").GetComponent<PressButton>().rend.sharedMaterial = PressButton.buttonMaterial[0];
        //GameObject.Find("Button3").GetComponent<PressButton>().rend.sharedMaterial = PressButton.buttonMaterial[0];

        //PressButton2.rend.sharedMaterial = buttonMaterial[0];
        // PressButton3.rend.sharedMaterial = buttonMaterial[0];
        // etc.
    }

    #region buttons
    public static void Button1Pressed()
    {
        button1 = true; 
        order++;

        if (order == 1)
        {
            print("correct");
            currentlyWrong = false;
            PointLight1.light.color = Color.green;
        }
        else
        {
            Clear();
            PointLight1.light.color = Color.red;
            print("Wrong");
            //Change mat to red/ and or add pointlight
        }
    }

    public static void Button2Pressed()
    {
        button2 = true;
        order++;

        if (order == 2)
        {
            print("correct");
            //Change material to green/blue or place a point light where the button is?
            currentlyWrong = false;
            PointLight1.light.color = Color.green;
        }
        else
        {
            Clear();
            PointLight1.light.color = Color.red;
            print("Wrong");
        }
    }

    public static void Button3Pressed()
    {
        button3 = true;
        order++;

        if (order == 6)
        {
            print("correct");
            currentlyWrong = false;
            PointLight1.light.color = Color.green;
        }
        else
        {
            Clear();
            PointLight1.light.color = Color.red;
            print("Wrong");
        }
    }

    public static void Button4Pressed()
    {
        button4 = true;
        order++;

        if (order == 3)
        {
            print("correct");
            currentlyWrong = false;
            PointLight1.light.color = Color.green;
        }
        else
        {
            Clear();
            PointLight1.light.color = Color.red;
            print("Wrong");
        }
    }

    public static void Button5Pressed()
    {
        button5 = true;
        order++;

        if (order == 4)
        {
            print("correct");
            currentlyWrong = false;
            PointLight1.light.color = Color.green;
        }
        else
        {
            Clear();
            PointLight1.light.color = Color.red;
            print("Wrong");
        }
    }

    public static void Button6Pressed()
    {
        button6 = true;
        order++;

        if (order == 5)
        {
            print("correct");
            currentlyWrong = false;
            PointLight1.light.color = Color.green;
        }
        else
        {
            Clear();
            PointLight1.light.color = Color.red;
            print("Wrong");

        }
    }
    #endregion
}


