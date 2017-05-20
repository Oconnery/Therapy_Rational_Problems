using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpStick : MonoBehaviour
{
    float Distance = PlayerCast.distanceFromTarget;
    private Text Disp;

    GameObject DoorStick;
    //GameObject Door;



    // Use this for initialization
    void Start ()
    {
        //DoorStick = GameObject.Find("StickDoor");
        //DoorStick.SetActive(false);
       /// Door = GameObject.Find("Door");

        Disp = GameObject.Find("Text").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
		

	}

    private void OnMouseOver()
    {
        Distance = PlayerCast.distanceFromTarget;

        if (Distance <= 5 && (PlayerCast.target.name.Equals("StickGround")))
        {
            Disp.text = "Pick Up?";
            if (Input.GetButtonDown("Action"))
            {
                BrokenDoorNature.Stick = true;
                Disp.text = "";
                gameObject.SetActive(false);
           }
        }

        
        if (Distance > 6)
        {
            Disp.text = "";
        }
    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }
}
