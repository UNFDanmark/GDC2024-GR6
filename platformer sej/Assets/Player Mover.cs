using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
	private Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    public int speed = 10;



    // Update is called once per frame
void Update()
{

    Vector3 move = rigidbody.velocity;
    rigidbody.velocity = move;
        move.x = Input.GetAxisRaw("Horizontal");
        move.z = Input.GetAxisRaw("Vertical");
        rigidbody.velocity = move;
    }
}  
    