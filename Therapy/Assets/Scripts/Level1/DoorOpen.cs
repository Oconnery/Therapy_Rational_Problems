using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    public static GameObject Door;
    public static bool Open1 = false;
    public bool hasPlayed = false; 

    // Use this for initialization
    void Start ()
    {
        GameObject door = gameObject; 
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Open1)
        {
            if (hasPlayed == false)
            {
                GetComponent<GameObject>();
                GetComponent<Animation>().Play("DoorOpen");
                print("Opening Door...");
                hasPlayed = true;
            }
          
            //bool play = GetComponent<Animation>().IsPlaying("DoorOpen");
            //if (play == false)
            //{
            //    Puzzle1Script.Clear();
            //}
        }

    }

    public static void Open()
    {
        Open1 = true; 
    }
    private static void PlayOpen()
    {
        //
    }

    //Add stuff for second door, third etc. 
}
