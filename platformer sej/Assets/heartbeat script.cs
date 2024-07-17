 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartbeatscript : MonoBehaviour
{
    public Transform water;
    public Transform player;
    private float waterdistance;
    public float heartbeatdistance;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        waterdistance = player.transform.position.y - water.transform.position.y;
        if (waterdistance < heartbeatdistance && audioSource.isPlaying == false)
        {
            print("hej");
            audioSource.Play();
        }
        else if (waterdistance > heartbeatdistance)
        {
            audioSource.Stop();
        }
    }
}
