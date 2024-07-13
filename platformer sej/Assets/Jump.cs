using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    
    private Rigidbody rigidbody;
    public Transform orientation;
    public float speed = 1.5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {
        Vector3 move = rigidbody.velocity;
        move.y = 0;
        move = move + Input.GetAxisRaw("Horizontal") * orientation.up * speed;
    }
}
