using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointLight1 : MonoBehaviour {

    public static Light light;

    void Start ()
    {
        light = GetComponent<Light>();
        light.color = Color.red;
    }
	
	void Update ()
    {

    }
}
