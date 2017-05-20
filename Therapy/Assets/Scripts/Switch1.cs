using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch1 : MonoBehaviour
{
    float Distance = PlayerCast.distanceFromTarget;
    GameObject Wire;
    GameObject Lever;
    GameObject Door;


    public Material wireMat;
    public Renderer rend;
    private Text Disp;

    // Use this for initialization
    void Start ()
    {
        Wire = GameObject.Find("Wire");
        Lever = GameObject.Find("Lever");
        Door = GameObject.Find("Door"); 
        
        rend = Wire.GetComponent<Renderer>();
        rend.enabled = true;
        Disp = GameObject.Find("Text").GetComponent<Text>(); 
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnMouseOver()
    {
        Distance = PlayerCast.distanceFromTarget; 

        if (Distance <= 4)
        {
            Disp.text = "Activate Switch";

            if (Input.GetButtonDown("Action"))
            {
                Lever.GetComponent<Animation>().Play("Switch1");
                Door.GetComponent<Animation>().Play("platDrop2Door");
                rend.sharedMaterial = wireMat;
            }
        }
        else if (Distance > 4)
        {
            Disp.text = "";
        }
    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }
}
