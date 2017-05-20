using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCast : MonoBehaviour
{

    
    public static float distanceFromTarget;
    float toTarget;
    public static Collider target;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        // Ray buttonRay = new Ray(transform.position, Vector3.forward); 

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = toTarget;
            target = hit.collider;
        }

    }

    private void OnGUI()
    {
     //   GUILayout.Label("RayCast Distance: " + distanceFromTarget);
    }
}
