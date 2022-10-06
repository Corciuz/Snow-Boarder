using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
  [SerializeField] float ReloadTime=1f;
  [SerializeField] ParticleSystem FinishLineEffect;
  public static int count=2;
   void OnTriggerEnter2D(Collider2D other) {
   if(other.tag=="Player"){
    FinishLineEffect.Play();
    GetComponent<AudioSource>().Play();
    Invoke("ReloadScene",ReloadTime);
   }
   
  }

  void ReloadScene(){
    count=count+1;
SceneManager.LoadScene(count);

  }
  
  
}
