using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedDoor : MonoBehaviour
{
    //Leads back to the anti grav room

    public GameObject redBox;
    public GameObject greenBox;
    public GameObject blueBox;
    public Transform antiGravRoom;
    public Vector3 posBlue;
    public Vector3 posGreen;
    public Vector3 posRed;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            print("player collided red");
            col.transform.position = new Vector3(27.0f, 1.0f, 29.0f);

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
            greenBox.transform.SetParent(antiGravRoom, true);
            redBox.transform.SetParent(antiGravRoom, false);

            //Set new local position
            redBox.transform.localPosition = posRed;
            greenBox.transform.localPosition = posGreen;


            //BLUE
            posBlue = blueBox.GetComponent<Transform>().localPosition;
            blueBox.transform.parent = null;
            blueBox.transform.SetParent(antiGravRoom, false);
            blueBox.transform.localPosition = posBlue;
        }
    }
}