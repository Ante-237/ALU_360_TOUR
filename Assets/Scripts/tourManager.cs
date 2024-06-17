using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tourManager : MonoBehaviour
{

    private void Start()
    {
        
    }

    public void RestartScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
