using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button4 : MonoBehaviour
{
    //public GameObject anim; 
    public GameObject button;
    public GameObject Player;

    public Material[] buttonMaterial3; //Material array
    public Renderer rend3;

    void Start()
    {
        //rend3 = GetComponent<Renderer>();
        //rend3.enabled = true; // just incase it's disabled for some reason
        //rend3.sharedMaterial = buttonMaterial3[0]; //material starts off at mat 0
    }

    void Update()
    {
       
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<GameObject>();
            GetComponent<Animation>().Play("Press4");
            GetComponent<AudioSource>().Play();

            print("Button 4 Triggered");

            Puzzle1Script1.Button4Pressed();

            //if (Puzzle1Script.order == 6)
            //{
            //    rend3.sharedMaterial = buttonMaterial3[1]; // blue
            //    print("3toBlue");
            //}
        }

    }




}
