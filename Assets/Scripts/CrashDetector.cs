using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float ReloadTime=0.5f;
    [SerializeField] ParticleSystem CrashEffect;
    [SerializeField] AudioClip crashSFX;
    bool HasCrush=false;
     void OnTriggerEnter2D(Collider2D other) {
        if(other.tag=="Ground"&&!HasCrush){
            HasCrush=true;
            FindObjectOfType<PlayerController>().DisableControls();
            CrashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene",ReloadTime);
        }
    }
    void ReloadScene(){
SceneManager.LoadScene(1);

  }
  
}
