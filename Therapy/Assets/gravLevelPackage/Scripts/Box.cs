using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour {

    float Distance = PlayerCast.distanceFromTarget;
    Text Disp;  //UI TEXT

    // Use this for initialization
    void Start () {

    Disp = GameObject.Find("Text").GetComponent<Text>();
        //Disp.text = "Move box";
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseOver ()
    {
        
        Distance = PlayerCast.distanceFromTarget;
        if (Distance <= 5) //and the distance between player and object is less than 3 units
        {
            Disp.text = "Interact";

            if (Input.GetButtonDown("Action")) //If (player presses E OR right clicks)
            {
                //push
                Vector3 rot = GameObject.Find("FirstPersonCharacter").transform.forward;
               // Vector3 force = new Vector3(rot.x, 0, rot.z) * 1000;
                print("force:"+ rot);

                gameObject.GetComponent<Rigidbody>().AddForce(rot*22000);
//                gameObject.GetComponent<moveAI>().SetTarget(PlayerCast.target.gameObject.transform.position);
            }


            if (Input.GetKeyDown(KeyCode.Q))// IF player presses Q?)
            {
                Vector3 rot = GameObject.Find("FirstPersonCharacter").transform.forward * -1;

                //Vector3 rot = GameObject.Find("FirstPersonCharacter").transform.up;

                print("force:" + rot);
                gameObject.GetComponent<Rigidbody>().AddForce(rot * 22000);
            }
        }
    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }
}