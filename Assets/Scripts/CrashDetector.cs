
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
   [SerializeField] float LoadDelay = 2f;
   [SerializeField] ParticleSystem crashEffect;
   [SerializeField]  AudioClip crashSFX;
   bool hasCrashed = true;
   void OnTriggerEnter2D(Collider2D other) 
   {
      if(other.tag == "Ground" && hasCrashed)
      {
         FindObjectOfType<PlayerController>().DisableControls();
         crashEffect.Play();
         GetComponent<AudioSource>().PlayOneShot(crashSFX);
         Invoke("ReloadScene",LoadDelay);
         hasCrashed=false;
      }
   }

   void ReloadScene()
      {
         SceneManager.LoadScene(0);
      }
}
