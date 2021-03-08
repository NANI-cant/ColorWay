using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackLine : MonoBehaviour
{
    private Animator anim;
    private bool canActivate = true;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Sphere") && canActivate){
            anim.SetTrigger("BlackCubeActivate");
            canActivate = false;
        }
    }

    public void ReActivate(){
        canActivate = true;
        anim.SetTrigger("BlackCubeRestart");
    }
}
