using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trig : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.CompareTag("Player"))
        {
            print("hit");
        }
    }
}
