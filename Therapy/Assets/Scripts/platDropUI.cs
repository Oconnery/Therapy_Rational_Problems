using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class platDropUI : MonoBehaviour
{
    float distance = PlayerCast.distanceFromTarget;

    private Text Disp;
    GameObject[] plats; 
    public Material mat1;
    GameObject InvisWall;

    // Use this for initialization
    void Start()
    {

        Disp = GameObject.Find("Text").GetComponent<Text>();
        plats = GameObject.FindGameObjectsWithTag("StaticTile");
        InvisWall = GameObject.Find("InvisWall");
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
            Disp.text = "Memorise the Pattern, then Press E to continue";
            if (Input.GetKeyDown(KeyCode.E) || Input.GetButtonDown("Fire1"))
            {

                Disp.text = "";
                //change the platform colours then delete this object.
                for (int i = 0; i < plats.Length; i++)
                {
                    plats[i].GetComponent<Renderer>().sharedMaterial = mat1;
                }

                InvisWall.SetActive(false);

                this.gameObject.SetActive(false);
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
