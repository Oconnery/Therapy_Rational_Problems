using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAI : MonoBehaviour {

    public Vector3 targetPos;
    public float speed = 1;
	// Use this for initialization
	void Start () {
        targetPos = transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        if (Mathf.Abs((targetPos - transform.position).magnitude) > 0.5f)
        {
            transform.position += (targetPos - transform.position).normalized * speed;
        }

	}

    public void SetTarget(Vector3 v)
    {
        targetPos = v;
    }
}
