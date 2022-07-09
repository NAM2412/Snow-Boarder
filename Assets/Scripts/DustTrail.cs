using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
   [SerializeField] ParticleSystem touchingGroundEffect;
   void OnCollisionEnter2D(Collision2D other) 
   {
        if (other.gameObject.tag == "Ground")
        {
            touchingGroundEffect.Play();
        }
   }
   void OnCollisionExit2D(Collision2D other) 
   {
     if (other.gameObject.tag == "Ground")
        {
            touchingGroundEffect.Stop();
        }
   }
}
