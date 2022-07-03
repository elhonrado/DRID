using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public manager gm;

    void OnTriggerEnter(){
        gm.leveldone();
    }
}