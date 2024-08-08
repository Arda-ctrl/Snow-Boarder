using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torque : MonoBehaviour
{
    [SerializeField] float rightClick = 1f;

    [SerializeField] float leftClick = -1f;

    Rigidbody2D myRigidBody;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D)){
            myRigidBody.AddTorque(rightClick);
        }
        if(Input.GetKey(KeyCode.A)){
            myRigidBody.AddTorque(leftClick);
        }
    }
}
