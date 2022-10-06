using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffecter2D;
    [SerializeField] float torqueAmmount=1f;
    [SerializeField] float BoostSpeed=30f;
    [SerializeField] float BaseSpeed=20f;
    [SerializeField] float BreakSpeed=10f;
    bool canMove=true;
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
        surfaceEffecter2D=FindObjectOfType<SurfaceEffector2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){

        
        Rotate();
        RespondToBoost();
        }
    }
    public void DisableControls(){
canMove=false;
    }

     void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffecter2D.speed=BoostSpeed;
        }else if(Input.GetKey(KeyCode.DownArrow)){
            surfaceEffecter2D.speed=BreakSpeed;

        }else{
            surfaceEffecter2D.speed=BaseSpeed;
        }
    }

    void Rotate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmmount);
        }
    }
}
