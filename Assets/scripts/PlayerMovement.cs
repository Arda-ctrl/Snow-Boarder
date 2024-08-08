using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torque : MonoBehaviour
{
    [SerializeField] float rightClick = 1f;

    [SerializeField] float leftClick = -1f;

    [SerializeField] float boostSpeed = 30f;

    [SerializeField] float normalSpeed = 10f;

    SurfaceEffector2D surfaceEffector2D;

    Rigidbody2D myRigidBody;

    bool canMove = true;
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
        RotatePlayer();
        BoostPlayer();
        }
    }

    public void DisableControls(){
        canMove = false;
    }
    void BoostPlayer()
    {
        if(Input.GetKey(KeyCode.W))
        {
            surfaceEffector2D.speed = boostSpeed;
        }else{
            surfaceEffector2D.speed = normalSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidBody.AddTorque(rightClick);
        }else if (Input.GetKey(KeyCode.A))
        {
            myRigidBody.AddTorque(leftClick);
        }
    }
}
