using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCube : MonoBehaviour
{
    public float speed = 3f;
    void Update(){

        transform.Translate(-speed*Vector3.up*Time.deltaTime, Space.World); 
        
    }
}
