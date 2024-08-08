using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class snowEffects : MonoBehaviour
{
    [SerializeField] ParticleSystem groundEffects;
    

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "ground")
        {
            groundEffects.Play();
        }
    }
     void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "ground")
        {
            groundEffects.Stop();
        }
    }
    }
    

