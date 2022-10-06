using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem Dusttrail;
    
  void OnCollisionEnter2D(Collision2D other) {
    
   
        if(other.gameObject.tag=="Ground"){
            Dusttrail.Play();
           
            
    }
   }
    void OnCollisionExit2D(Collision2D other) {
    if(other.gameObject.tag=="Ground"){
          Dusttrail.Stop();
    }
  }
}
