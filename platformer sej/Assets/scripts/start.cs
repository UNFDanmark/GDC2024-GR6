using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    [SerializeField] private string sunken = "test1";
    
    public void startbutton()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
