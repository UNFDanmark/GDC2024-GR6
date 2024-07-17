using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleThemeScript : MonoBehaviour
{
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.volume = 0f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        audiosource.volume += 0.01f;
    }
}
