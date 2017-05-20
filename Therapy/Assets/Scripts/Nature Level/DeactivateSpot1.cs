using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateSpot1 : MonoBehaviour
{
    GameObject Spotlight1;
    bool active = true;

	// Use this for initialization
	void Start ()
    {
        Spotlight1 = GameObject.Find("Spotlight");
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Spotlight1.SetActive(!active);
        active = !active;
    }
}
