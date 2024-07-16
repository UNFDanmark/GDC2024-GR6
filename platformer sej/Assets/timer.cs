using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timertext;
    public float elapsedTime;
    
    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        int minutes = Mathf.FloorToInt(elapsedTime / 60);
        int seconds = Mathf.FloorToInt(elapsedTime % 60);
        timertext.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
