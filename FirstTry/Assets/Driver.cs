using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Driver : MonoBehaviour{
    
    
    [SerializeField] float slowspeed = 10;
    [SerializeField] float boostspeed = 20;
    [SerializeField] float steerSpeed = 200;
    [SerializeField] float moveSpeed = 15;


    void Update(){   
        float steerAmount= Input.GetAxis("Horizontal")* steerSpeed * Time.deltaTime;
        float moveAmount= Input.GetAxis("Vertical")* moveSpeed * Time.deltaTime;
        transform.Translate(0, moveAmount, 0);
        transform.Rotate(0, 0 , -steerAmount);
        
    }

    private void OnCollisionEnter2D(Collision2D other){
        moveSpeed = slowspeed;
        
    }
    private void OnTriggerEnter2D(Collider2D other){
        if (other.tag=="Boost")
        {
            moveSpeed = boostspeed;
        }
        
    }
}
