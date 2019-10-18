using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 100f;
    // Update is called once per frame
    void FixedUpdate()
    {   
        //forward
        if (Input.GetKey("w")) 
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        //backwards
        if (Input.GetKey("s")) 
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        } 
        //left
        if (Input.GetKey("a")) 
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //right
        if (Input.GetKey("d")) 
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
