using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 1.5f;
    public Rigidbody rb;
    public bool Grounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2.0f, 0);
    }

    // Update is called once per frame
    void Update()
    
    {
       
    }
}
