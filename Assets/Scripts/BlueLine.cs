using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLine : MonoBehaviour
{
    public GameObject BlueButon;
    private Animator anim;
    private bool canActivate = true;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other){
       if(other.gameObject.CompareTag("Sphere")){
           if(BlueButon.GetComponent<BlueEm>().canStep){
               if(canActivate){
                   anim.SetTrigger("BlueActivate");
                    canActivate = false;
               }
            }else{
                other.gameObject.GetComponent<sphereControl>().Hit(4);
            }
       }
    }

   public void ReActivate(){
        canActivate = true;
        anim.SetTrigger("BlueRestart");
    }
}
