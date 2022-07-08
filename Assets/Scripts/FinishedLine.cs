
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLine : MonoBehaviour
{
    [SerializeField] float LoadDelay = 2f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            Invoke("ReloadScene",LoadDelay);
            Debug.Log("Finish");
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
