using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int verticalmove = 2000;
    public int horizontalmove = 1000;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            rb.AddForce(0,0,verticalmove * Time.deltaTime);
        };
        if(Input.GetKey("s")){
            rb.AddForce(0,0,-verticalmove * Time.deltaTime);
        };
        if(Input.GetKey("a")){
            rb.AddForce(-verticalmove * Time.deltaTime,0,0);
        };
        if(Input.GetKey("a")){
            rb.AddForce(verticalmove * Time.deltaTime,0,0);
        };
    }
}
