using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Death : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="ground"){
        Debug.Log("oyh");

     } 
    }
}
