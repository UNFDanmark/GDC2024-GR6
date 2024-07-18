using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMover : MonoBehaviour
{
	private Rigidbody rigidbody;
    private Camera mainCam;
    public float maxspeed = 1000000f;
    public float basespeed = 2;
    public Transform orientation;
    public float cooldown = 0.2f;
    float cooldownLeft;
    public AudioSource audioSource;
    public bool grounded;
    public AudioClip runsound;
    private bool running;
    public AudioClip slidesound;
    public AudioClip slidestop;

    private Vector3 move;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        mainCam = Camera.main;
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }
    
    private void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("ground"))
        {
            grounded = false;
        }
    }

    public Collider CrouchCollider;
    // Update is called once per frame
    void Update()
    {
        
        move = new Vector3();
        
        move = move + Input.GetAxisRaw("Horizontal") * orientation.right * basespeed;
        move = move + Input.GetAxisRaw("Vertical") * orientation.forward * basespeed;
        
        move = Vector3.ClampMagnitude(move, maxspeed);
        //print(move);
       
        
        if (move == Vector3.zero && grounded)
        {
            //standing still on the ground
            
            print("move");
            audioSource.Stop();
            
        } else if (move != Vector3.zero && grounded)
        {
            // move on the ground 
            if (!running)
            {
                audioSource.clip = runsound;
                audioSource.Play();
            }
            
        }
        else if (!grounded)
        {
            // in mid-air
            audioSource.Stop();
        }
        

        cooldownLeft = cooldownLeft - Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.LeftShift)&& cooldownLeft <= 0)
        {
            audioSource.Stop();
            rigidbody.AddForce(move*100);
            cooldownLeft = cooldown;
            audioSource.clip = slidesound;
            audioSource.Play();
            


        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            audioSource.Stop();
            audioSource.clip = slidestop;
            audioSource.Play();
        }
        running = move != Vector3.zero && grounded;
        
    }

    private void FixedUpdate()
    {
        float gravity = rigidbody.velocity.y;
        rigidbody.AddForce(move,ForceMode.Acceleration);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("water"))
        {
            SceneManager.LoadScene("Main Scene");
        }
    }
    }
    
    



