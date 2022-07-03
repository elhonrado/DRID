using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public PlayerScript pmovement;

    void OnCollisionEnter(Collision collisioninfo){
        if (collisioninfo.collider.tag == "Obstacle"){
            pmovement.enabled = false;
            FindObjectOfType<manager>().EndGame();
        }
        
    }
    /*void FixedUpdate(){
        if (Input.GetKey("w"))
        {
            if (Input.GetKey("p")){
                pmovement.enabled = true;
            }

        }
    }*/
}
