using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class platDrop2End : MonoBehaviour
{
    float distance = PlayerCast.distanceFromTarget;

    private Text Disp;

    // Use this for initialization
    void Start()
    {
        Disp = GameObject.Find("Text").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseOver()
    {
        distance = PlayerCast.distanceFromTarget;

        if (distance <= 4)
        {
            Disp.text = "Continue to Next Level?";
            if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene("Anti_Gravity_Room");
            }
        }
        if (distance > 4)
        {
            Disp.text = "";
        }
    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }
}
