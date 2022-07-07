
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            Invoke("ReloadScene",2f);
            Debug.Log("Finish");
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}