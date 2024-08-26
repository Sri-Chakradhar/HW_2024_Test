using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int verticalForce = 2000;
    public int horizontalForce = 2000;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w")){
            rb.AddForce(0,0,verticalForce * Time.deltaTime);
        };
        if(Input.GetKey("s")){
            rb.AddForce(0,0,-verticalForce * Time.deltaTime);
        };
        if(Input.GetKey("a")){
            rb.AddForce(-horizontalForce * Time.deltaTime,0,0);
        };
        if(Input.GetKey("d")){
            rb.AddForce(horizontalForce * Time.deltaTime,0,0);
        };
    }
}
