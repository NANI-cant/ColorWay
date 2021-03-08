using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public GameObject[] Platforms;
    public GameObject[] Cubes;
    private void Start(){
        StartCoroutine(SpawnCube());
    }

    IEnumerator SpawnCube(){
        int randCube = Random.Range(0,4);
        int randPlatform = Random.Range(0,4);
        float randTime = Random.Range(0f,5f);
        yield return new WaitForSeconds(randTime);
        StartCoroutine(SpawnCube());
        Vector3 Pos = Platforms[randPlatform].transform.position;
        Vector3 Scale = Platforms[randPlatform].transform.localScale/2;
        Vector3 FinPos = new Vector3(Random.Range(Pos.x-Scale.x,Pos.x+Scale.x),60f,Random.Range(Pos.z-Scale.z,Pos.z+Scale.z));
        Instantiate(Cubes[randCube], FinPos, Quaternion.identity);
    }
}
