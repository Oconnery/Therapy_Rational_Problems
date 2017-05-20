using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DeactivateSpot2 : MonoBehaviour
{
    GameObject Spotlight;
    bool active = false;

    // Use this for initialization
    void Start()
    {
        Spotlight = GameObject.Find("SpotLight2");
        Spotlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Spotlight.SetActive(!active);
            active = !active;
        }
    }
}