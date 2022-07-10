
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedLine : MonoBehaviour
{
    
    [SerializeField] float LoadDelay = 2f;
    [SerializeField] ParticleSystem finishEffect;
    
    void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene",LoadDelay);
            Debug.Log("Finish");
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
