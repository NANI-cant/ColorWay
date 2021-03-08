using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueEm : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip standSound;
    public bool canStep = false;
   private void OnTriggerEnter(Collider other){
       if(other.gameObject.CompareTag("Sphere")){
           if(!canStep){
               audio.PlayOneShot(standSound);
           }
           canStep = true;
       }
   }
}
