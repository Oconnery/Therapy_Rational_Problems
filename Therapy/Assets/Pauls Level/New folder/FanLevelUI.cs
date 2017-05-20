using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FanLevelUI : MonoBehaviour
{
    float distance = PlayerCast.distanceFromTarget;

    private Text Disp;
    public Material mat1;

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
        if (distance <= 4)
        {


            Disp.text = "Press";
            if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire1"))
            {
                Disp.text = "";
                SceneManager.LoadScene("platformDrop");
            }
        }
        else
        {
            Disp.text = "";
        }
    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }
}
