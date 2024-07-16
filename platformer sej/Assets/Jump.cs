using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))] 
public class Jump : MonoBehaviour

{
    AudioSource audioSource;
    public Vector3 jump;
    public float jumpForce = 1.5f;
    public Rigidbody rb;
    public bool grounded;

    public AudioClip jumpsound;

    public AudioClip jumpland;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2.0f, 0);
    }

    // Update is called once per frame
    void Update(){
        
        if(Input.GetKeyDown(KeyCode.Space) && grounded){
            //Debug.Log("does this work");
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        
            grounded = false;
            audioSource.clip = jumpsound;
            //audioSource.Play();
            AudioSource.PlayClipAtPoint(jumpsound, transform.position, 1f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            //Debug.Log("test");
            grounded = true;
            audioSource.clip = jumpland;
            audioSource.Play();
            //AudioSource.PlayClipAtPoint(jumpland, transform.position, 0.8f);

        }
    }
}
