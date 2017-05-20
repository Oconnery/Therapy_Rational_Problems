using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button2 : MonoBehaviour
{
    //public GameObject anim; 
    public GameObject button;
    public GameObject Player;

    public Material[] buttonMaterial3 = new Material[2]; //Material array
    public Renderer rend3;

    void Start()
    {
        rend3 = GetComponent<Renderer>();
        rend3.enabled = true; // just incase it's disabled for some reason
        rend3.sharedMaterial = buttonMaterial3[0]; //material starts off at mat 0
    }

    void Update()
    {
        //will be true until the player clicks another button which is in the correct order
        if (Puzzle1Script1.currentlyWrong == true && rend3.sharedMaterial != buttonMaterial3[0]) 
        {
            rend3.sharedMaterial = buttonMaterial3[0]; // reset mat to default
            print("Update3, changetoGrey");
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<GameObject>();
          //  GetComponent<Animation>().Play("Press2");
            GetComponent<AudioSource>().Play();

            print("Button 2 Triggered");

            Puzzle1Script1.Button2Pressed();

        }

    }




}
