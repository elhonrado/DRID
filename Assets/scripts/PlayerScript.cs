using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;

    public float ForwardForce=1200f;
    public float SideForce=200f;
    //public float JumpForce=400f;

    // Start
    void Start()
    {
        Debug.Log("The game is starting");
    }

    //control begins here
    void FixedUpdate()
    {
        rb.useGravity = true; //activate gravity
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,ForwardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-ForwardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(SideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<manager>().EndGame();
        }
        /*if (Input.GetKey("h"))
        {
            rb.useGravity = false;
        }
        if (Input.GetKey("g"))
        {
            rb.useGravity = true;
        }
        if (Input.GetKey("i"))
        {
            rb.AddForce(0,JumpForce * Time.deltaTime,0);
        }
        if (Input.GetKey("k"))
        {
            rb.AddForce(0,-JumpForce * Time.deltaTime,0);
        }*/

    }
}