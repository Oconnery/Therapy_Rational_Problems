using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PushTree : MonoBehaviour
{

    float Distance = PlayerCast.distanceFromTarget;
    private Text Disp;
    bool Collapsed = false;

    // Use this for initialization
    void Start ()
    {
        Disp = GameObject.Find("Text").GetComponent<Text>();
    }


    private void OnMouseOver()
    {
        Distance = PlayerCast.distanceFromTarget;

        if (!Collapsed)
        {
            if (Distance <= 6  && (PlayerCast.target.name.Equals("Tree")))
            {
                Disp.text = "Push tree?";
                if (Input.GetButtonDown("Action"))
                {
                    gameObject.GetComponent<Animation>().Play("TreeFalling");
                    Collapsed = true;
                }
            }

        }
            if (Distance > 6)
            {
                Disp.text = "";
            }
    }

    private void OnMouseExit()
    {
        Disp.text = "";
    }

    void WallHit()
    {
        GameObject.Find("Collapsing Wall").GetComponent<Animation>().Play("Collapsing Wall");
    }
}
