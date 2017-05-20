using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platFall : MonoBehaviour
{
    public bool drop;




	// Use this for initialization
	void Start ()
    {
        drop = false; 
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
		if(!drop)
        {
            gameObject.GetComponent<Rigidbody>().Sleep();
        }
        else if(drop)
        {
            gameObject.GetComponent<Rigidbody>().WakeUp();
        }
       
	}

     void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("Collide");
            drop = true;
            gameObject.GetComponent<Rigidbody>().AddForce(0f, -200f, 0f);
            //GameObject.Find("InvisWall").SetActive(true);
           // gameObject.transform.Rotate(new Vector3(0f, 0f, 180f));
           // GameObject.Find("InvisWall").GetComponent<Animation>().Play("");
            //collision.transform.localPosition = GameObject.Find("GameObject").transform.localPosition; //new Vector3(0f, 0f, 0f);
        }
    }
}
