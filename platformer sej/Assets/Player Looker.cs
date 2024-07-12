using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLooker : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    void Start()
    
    {
       
        {
            rb = GetComponent<Rigidbody>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        int speed = 10;
        
        if (speed > 18)
        {
            print("Du er speed");
        }
        else
        {
            print("Du er aight");
        }
        
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");
        }
        {
            Vector3 movement = rb.velocity;
            movement.x = Input.GetAxisRaw("Horizontal") * speed;
            movement.z = Input.GetAxisRaw("Vertical") * speed;
            rb.velocity = movement;
        }
        {
            var transform = GetComponent<Transform>();
        }
        {
            transform.Rotate(0, 5, 0);
        }
        }   
    } 


        
        
