using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderdisable : MonoBehaviour
{
    public GameObject boxcastcentre;

    public Vector3 HalfExtent;

    public LayerMask layermask;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public bool enabled = true;
   
    // Update is called once per frame
    void Update()
    
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            GetComponent<Collider>().enabled= false;
        }
        else
        {
            bool hit = Physics.BoxCast(boxcastcentre.transform.position, HalfExtent, Vector3.up, Quaternion.identity, 1f,
                layermask);

            if (hit)
            {
                Debug.Log("hit");
            }
            else
            {
                GetComponent<Collider>().enabled= true;
                Debug.Log("no hit");
            }
            
        }
    }

    private void OnDrawGizmos()
    {
        // draws a box to show boxcast - incorrect math though
        //Vector3 center = boxcastcentre.transform.position + Vector3.up * 1 / 2;
        //Vector3 size = HalfExtent * 2;
        //Gizmos.DrawWireCube(center, size);
    }
}
