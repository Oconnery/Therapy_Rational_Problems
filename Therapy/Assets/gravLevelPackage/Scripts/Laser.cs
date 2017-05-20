using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Laser : MonoBehaviour
{
    ParticleSystem laser;
    float toTarget;
    public static Collider target;
    public GameObject playa;
    static bool an;

    // Use this for initialization
    void Start()
    {
        laser = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!laserButton.laserOff)
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            //Say if a seperate Raycast collides with a box, store the distance as toTarget

            RaycastHit hit;

            if (Physics.Raycast(transform.position, fwd, out hit, 10.0f))
            if(hit.distance != 0)
            {
               //print(hit.collider);
               if(hit.collider.tag == "Player")
               {
                   print("Kill player");
                    SceneManager.LoadScene("Anti_Gravity_Room");
                }
               // print(hit.distance);

            }
    }

       //if (hit. "Player")
       // {
            //Restart the level

       // }

        //If the laser should be off
        if (laserButton.laserOff)
        {
            //Turn off the laser particle system
            laser.Stop();

        }
    }
}