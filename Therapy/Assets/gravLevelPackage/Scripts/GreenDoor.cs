using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenDoor : MonoBehaviour {
    //Leads to 90 antigrav Room

    public GameObject redBox;
    public GameObject greenBox;
    public GameObject blueBox;
    public Transform ninetyGravRoom;
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
            col.transform.position = new Vector3(5f, -39f, 41.0f);

            //Store position
            posRed = redBox.GetComponent<Transform>().localPosition;
            posGreen = greenBox.GetComponent<Transform>().localPosition;

            //
            //Change boxes parent
            //

            //Detatch parent
            greenBox.transform.parent = null;
            redBox.transform.parent = null;

            //Set to new parent
            greenBox.transform.SetParent(ninetyGravRoom, true);
            redBox.transform.SetParent(ninetyGravRoom, false);

            //Set new local position
            redBox.transform.localPosition = posRed;
            greenBox.transform.localPosition = posGreen;

            posBlue = blueBox.GetComponent<Transform>().localPosition;
            blueBox.transform.parent = null;
            blueBox.transform.SetParent(ninetyGravRoom, false);
            blueBox.transform.localPosition = posBlue;
        }
    } 
}