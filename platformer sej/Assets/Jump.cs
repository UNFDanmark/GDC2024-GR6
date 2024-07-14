using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))] 
public class Jump : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 1.5f;
    public Rigidbody rb;
    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2.0f, 0);
        
  
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && grounded){
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        
            grounded = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("test1");
        if (other.gameObject.CompareTag("ground"))
        {
            Debug.Log("test");
            grounded = true;
            
        }
    }
}
