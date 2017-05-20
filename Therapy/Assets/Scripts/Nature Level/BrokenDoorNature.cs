using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrokenDoorNature : MonoBehaviour
{
    bool Wedge = false;
    public static bool Stick = false;

    float distance = PlayerCast.distanceFromTarget;
    private Text Disp;
    GameObject Door;
    GameObject DoorStick;


	// Use this for initialization
	void Start ()
    {
		Disp = GameObject.Find("Text").GetComponent<Text>();
        Door = GameObject.Find("Door");
        DoorStick = GameObject.Find("StickDoor");
        DoorStick.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        BrokenLoop();
	}

    void BrokenLoop()
    {
        if(Wedge == false)
        {
            Door.GetComponent<Animation>().Play("DoorBrokeNature");
        }
		
    }


    private void OnMouseOver()
    {
        distance = PlayerCast.distanceFromTarget;

        if(distance <= 5 && (PlayerCast.target.name.Equals("DoorTrig")))
        {
           if(!Stick)
           {
               Disp.text = "Need to find something to wedge this open with";
           }
           else if(Stick) // if the player has the stick, wedge the door
           {
                Disp.text = "Use the Stick on the Door?";
                if (Input.GetButtonDown("Action"))
                {
                    Wedge = true;
                    OpenDoor();
                    Disp.text = "";
                    DoorStick.SetActive(true);
                    gameObject.SetActive(false);
                }

            }
        }
        if (distance > 5)
        {
            Disp.text = "";
        }

    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }

    void OpenDoor()
    {
        Wedge = true;
        if(Wedge)
        {
            Door.GetComponent<Animation>().Play("DoorBrokeNatureWedge");
            print("open");
        }
    }
}
