using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandSound : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip jumpland;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HALLOOOOO");
        if (other.gameObject.CompareTag("ground"))
        {
            Debug.Log("test");
            AudioSource.PlayClipAtPoint(jumpland, transform.position, 0.8f);

        }
    }
}
