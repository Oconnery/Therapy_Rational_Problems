using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class titleController : MonoBehaviour
{
    GameObject Player;
    GameObject TempCam;
    Text UIText;
    Text Title;
    GameObject UICross;
    

    public static bool paused = true; 


	// Use this for initialization
	void Start ()
    {
        Player = GameObject.Find("FPSController");
        TempCam = GameObject.Find("TempCam");
        UIText = GameObject.Find("Text").GetComponent<Text>();
        UICross = GameObject.Find("Panel");
        Title = GameObject.Find("Title").GetComponent<Text>();

       
        Player.SetActive(false);
        UICross.SetActive(false);
        UIText.text = "Press enter to start";
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            UIText.text = "";
            Title.text = "";
            Player.SetActive(true);
            UICross.SetActive(true);
            TempCam.SetActive(false);
            paused = false; 
        }    	
	}


}
