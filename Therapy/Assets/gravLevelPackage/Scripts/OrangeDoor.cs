using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeDoor : MonoBehaviour {

    public GameObject redBox;
    public GameObject greenBox;
    public GameObject blueBox;
    public Transform GravRoom;
    public Vector3 posBlue;
    public Vector3 posGreen;
    public Vector3 posRed;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            print("player collided orange");
            col.transform.position = new Vector3(10f, 1f, -17f);

            //Store position
            posGreen = greenBox.GetComponent<Transform>().localPosition;

            //
            //Change boxes parent
            //

            //Detatch parent
            greenBox.transform.parent = null;
            
            //Set to new parent
            greenBox.transform.SetParent(GravRoom, true);
            
            //Set new local position
            greenBox.transform.localPosition = posGreen;

            //BLUE
            if (!Puzzle.blueComplete)
            {
                posBlue = blueBox.GetComponent<Transform>().localPosition;
                blueBox.transform.parent = null;
                blueBox.transform.SetParent(GravRoom, false);
                blueBox.transform.localPosition = posBlue;
            }
            else
            {
                posBlue = blueBox.GetComponent<Transform>().localPosition;
                posBlue.y += 8.0f;
                blueBox.transform.parent = null;
                blueBox.transform.SetParent(GravRoom, false);
                blueBox.transform.localPosition = posBlue;
            }

            //RED
            if (!Puzzle.redComplete)
            {
                posRed = redBox.GetComponent<Transform>().localPosition;
                redBox.transform.parent = null;
                redBox.transform.SetParent(GravRoom, false);
                redBox.transform.localPosition = posRed;
            }
            else
            {
                posRed = redBox.GetComponent<Transform>().localPosition;
                posRed.y -= 8.0f;
                redBox.transform.parent = null;
                redBox.transform.localPosition = posRed;
                redBox.transform.SetParent(GravRoom, false);
                
            }
        }

        //Play animation 
    }
}