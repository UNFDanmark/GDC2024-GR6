using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class PlayerMover : MonoBehaviour
{
	private Rigidbody rigidbody;
    private Camera mainCam;
    public float maxspeed = 1000000f;
    public float speed;
    public float basespeed = 2;
    public Transform orientation;
    public float cooldown = 0.2f;
    float cooldownLeft;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        mainCam = Camera.main;
        speed = basespeed;
    }

   

    public Collider CrouchCollider;
    // Update is called once per frame
    void Update()
    {
        
        Vector3 move = new Vector3();
        float gravity = rigidbody.velocity.y;
        move = move + Input.GetAxisRaw("Horizontal") * orientation.right * speed;
        move = move + Input.GetAxisRaw("Vertical") * orientation.forward * speed;
        rigidbody.AddForce(move);
        move = Vector3.ClampMagnitude(move, maxspeed);

        cooldownLeft = cooldownLeft - Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.LeftShift)&& cooldownLeft <= 0)
        
        {
            rigidbody.AddForce(move*250);
            cooldownLeft = cooldown;

        }
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("water"))
        {
            SceneManager.LoadScene("test1");
        }
    }
}



