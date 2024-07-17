using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public float highscore;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            
            DontDestroyOnLoad(gameObject);
            instance = this;

            instance.highscore = float.MaxValue;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Main Scene");
        }
    }

    public void UpdateHighscore(float newscore)
    {
        if (newscore<highscore)
        {
            highscore = newscore;
        }
    }
}
