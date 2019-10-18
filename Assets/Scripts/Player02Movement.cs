using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //forward
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            rb.AddForce(0, 0, force * Time.deltaTime, ForceMode.VelocityChange);
        }
        //backwards
        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            rb.AddForce(0, 0, -force * Time.deltaTime, ForceMode.VelocityChange);
        } 
        //left
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            rb.AddForce(-force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //right
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rb.AddForce(force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
