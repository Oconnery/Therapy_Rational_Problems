using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour {

    public static bool blueComplete;
    Vector3 blueLow; //The minimum value at which the block is placed in order to be accepted as being in the correct place in the puzzle
    Vector3 blueHigh; // "" Maximum
    Vector3 blueExact; // The exact position that the box should be moved to

    public static bool greenComplete;
    Vector3 greenLow;
    Vector3 greenHigh;
    Vector3 greenExact;

    public static bool redComplete;
    Vector3 redLow;
    Vector3 redHigh;
    Vector3 redExact;

    public GameObject blueBox;
    public GameObject greenBox;
    public GameObject redBox;

    // Use this for initialization
    void Start () {
        blueLow.Set(37.0f, 0.0f, -9.0f);
        blueHigh.Set(39.0f, 2.0f, -7.0f);
        blueExact.Set(39.0f, 1.0f, -8.00f);

        greenLow.Set(36.0f, 3.0f, -11.0f);
        greenHigh.Set(40.0f, 7.0f, -9.0f);
        greenExact.Set(39.0f, 5.0f, -10.0f);

        redLow.Set(36.0f, 7.0f, -14.0f);
        redHigh.Set(39.0f, 11.0f, -10.5f);
        redExact.Set(39.0f, 9.0f, -12.0f);
    }
	
	// Update is called once per frame
	void Update () {
        //If the position of any of the blocks is around the position that the block needs to be to complete that colour of the puzzle: 
        //Set position of block to the exact position the part of the puzzle requires
        //Light up all of the blocks for that part of the pattern (blue, or green, or red etc.)
        //Make it uninteractable

        //Position of the block once in the puzzle should change when walking through doors.

        //BlueBox
        if (blueBox.GetComponent<Transform>().localPosition.x > blueLow.x && blueBox.GetComponent<Transform>().localPosition.x < blueHigh.x)
            if (blueBox.GetComponent<Transform>().localPosition.y > blueLow.y && blueBox.GetComponent<Transform>().localPosition.y < blueHigh.y)
                if (blueBox.GetComponent<Transform>().localPosition.z > blueLow.z && blueBox.GetComponent<Transform>().localPosition.z < blueHigh.z)
                {
                    //Set position to exact position
                    blueComplete = true;
                    blueBox.GetComponent<Transform>().localPosition = blueExact;
                }

        //GreenBox
        if (greenBox.GetComponent<Transform>().localPosition.x > greenLow.x && greenBox.GetComponent<Transform>().localPosition.x < greenHigh.x)
            if (greenBox.GetComponent<Transform>().localPosition.y > greenLow.y && greenBox.GetComponent<Transform>().localPosition.y < greenHigh.y)
                if (greenBox.GetComponent<Transform>().localPosition.z > greenLow.z && greenBox.GetComponent<Transform>().localPosition.z < greenHigh.z)
                {
                    //Set position to exact position
                    greenComplete = true;
                    greenBox.GetComponent<Transform>().localPosition = greenExact;
                }

        //redBox
        if (redBox.GetComponent<Transform>().localPosition.x > redLow.x && redBox.GetComponent<Transform>().localPosition.x < redHigh.x)
            if (redBox.GetComponent<Transform>().localPosition.y > redLow.y && redBox.GetComponent<Transform>().localPosition.y < redHigh.y)
                if (redBox.GetComponent<Transform>().localPosition.z > redLow.z && redBox.GetComponent<Transform>().localPosition.z < redHigh.z)
                {
                    //Set position to exact position
                    redComplete = true;
                    redBox.GetComponent<Transform>().localPosition = redExact;
                }

        if (blueComplete == true && greenComplete == true && redComplete == true)
        {
            print("COMPLETE");
            EndDoor.door = true;   
        }
    }
}