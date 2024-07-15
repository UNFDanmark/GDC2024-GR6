using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.TextCore.Text;

public class PlayerMover : MonoBehaviour
{
	private Rigidbody rigidbody;
    private Camera mainCam;
    public float maxspeed = 10;
    public Transform orientation;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        mainCam = Camera.main;
    }

    public float speed = 1.5f;

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
        
    }  
}


