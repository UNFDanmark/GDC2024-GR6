using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMover : MonoBehaviour
{
    public float waterspeed = 0.01f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x,transform.position.y+waterspeed, transform.position.z);
    }
}
