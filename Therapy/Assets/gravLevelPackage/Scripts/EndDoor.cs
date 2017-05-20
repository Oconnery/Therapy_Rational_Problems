using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDoor : MonoBehaviour
{
    public static bool door = false;
    public static bool doorOpened = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Puzzle.blueComplete && Puzzle.redComplete && Puzzle.greenComplete)
        {
            //Play animation
            if (door == true && doorOpened == false)
            {
                print("Door should open");
                GetComponent<Animation>().Play("lastDoorOpen");
                doorOpened = true;
            }
        }
    }

}
