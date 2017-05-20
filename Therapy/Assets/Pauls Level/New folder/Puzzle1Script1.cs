using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1Script1 : MonoBehaviour {

    //ORDER OF BUTTONS = 1,3,6,8
    
    // Use this for initialization
    public static bool button1, button3, button6, button8;

    public static bool currentlyWrong = false;

    void Start ()
    {
        button1 = false; button3 = false; button6 = false; button8 = false;
    }

	void Update ()
    {
        if (button1 == true && button3 == true && button6 == true && button8 == true)
        {
            print("Door Should Open");
            DoorOpen.Open();

            //Disable buttons - anims and sounds

            // Change lighting? 
            //Buttons perhaps flicker a light 
            // Or/and the room lighting increases 
        }
    }

   

    #region buttons
    public static void Button1Pressed()
    {
        button1 = true;
        print("Button 1 is now true"); 
    }

    public static void Button2Pressed()
    {
        button1 = false;
        print("Button 1 is now false");
    }

    public static void Button3Pressed()
    {
        button3 = true;
        print("Button 3 is now true");
    }

    public static void Button4Pressed()
    {
        button3 = false;
        print("Button 3 is now false");
    }

    public static void Button5Pressed()
    {
        button6 = false;
        print("Button 6 is now false");
    }

    public static void Button6Pressed()
    {
        button6 = true;
        print("Button 6 is now true");
    }

    public static void Button7Pressed()
    {
        button8 = false;
        print("Button 8 is now false");

    }
    public static void Button8Pressed()
    {
        button8 = true;
        print("Button 8 is now true");
    }
    #endregion
}


