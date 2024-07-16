using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class winscript : MonoBehaviour

{
    public timer score;
    public GameObject winscreen;
    public GameObject timercanvas;
  
    public TextMeshProUGUI highscoretext;
    public TextMeshProUGUI scoretext;
    

    public float elapsedTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject varGameObject = GameObject.FindWithTag("Player");
            varGameObject.GetComponent<PlayerMover>().enabled = false;
            winscreen.SetActive(true);
            timercanvas.SetActive(false);
            ScoreManager.instance.UpdateHighscore(score.elapsedTime);
            highscoretext.text = "" + ScoreManager.instance.highscore;
            scoretext.text = "" + score.elapsedTime;
            
                GameObject water = GameObject.FindWithTag("water");
                water.GetComponent<WaterMover>().waterspeed = 0f;
            
        }
    }
}
