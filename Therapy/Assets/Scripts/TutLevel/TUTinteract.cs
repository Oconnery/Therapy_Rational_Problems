using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TUTinteract : MonoBehaviour
{
    float distance = PlayerCast.distanceFromTarget;

    private Text Disp;

	// Use this for initialization
	void Start ()
    {
        Disp = GameObject.Find("Text").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnMouseOver()
    {
        distance = PlayerCast.distanceFromTarget;

        if  (distance <= 4 && !titleController.paused)
        {
            Disp.text = " Click the mouse or Press E to interact with objects";
            if(Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire1"))
            {
                //Go to next level is only temp; 
                //Could possibly implement further tutorial level things 
                Disp.text = "";
                SceneManager.LoadScene("1");
            }
        }
        if(distance >4)
        {
            Disp.text = "";
        }
    }

    private void OnMouseExit()
    {
        if (!titleController.paused)
        {
            Disp.text = "";
        }
    }
}
