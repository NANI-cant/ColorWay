using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStopProc : MonoBehaviour
{
    public GameObject Cam;
    public GameObject Sph;
    private GameObject[] LineCubes;
    private GameObject[] BlueCubes;
    private GameObject[] BlackCubes;
    public GameObject BlueEm;
    private GameObject Finish;
    public GameObject Menu;
    private bool menuActive=false;
    public bool canSwap = true;
    private bool canR = true;
    private AudioSource audio;
    public AudioClip pickSound;


    public void Start(){
        audio=GetComponent<AudioSource>();
    }
    public void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            audio.PlayOneShot(pickSound);
            menuActive=!menuActive;
            Menu.SetActive(menuActive);
        }
        if(Input.GetKeyDown(KeyCode.R) && canR){
            canR=false;
            Restart();
            StartCoroutine(ActiveR());
        }
    }

    IEnumerator ActiveR(){
        yield return new WaitForSeconds(3f);
        canR=true;
    }
    public void StartStopGame(){
        if(canSwap){
            Cam.GetComponent<Timer>().TimeSwap();
            Sph.GetComponent<sphereControl>().MoveSwap();
            canSwap = !canSwap;
        }
    }

    public void SwapTrue(){
        canSwap = true;
    }

    public void Restart(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        canSwap = !canSwap;
        BlueEm.GetComponent<BlueEm>().canStep = false;
        Cam.GetComponent<Timer>().TimeToZero();
        Cam.GetComponent<Timer>().isFinish = false;
        Sph.GetComponent<sphereControl>().Restart();
        LineCubes = GameObject.FindGameObjectsWithTag("Line");
        BlueCubes = GameObject.FindGameObjectsWithTag("BlueLine");
        BlackCubes = GameObject.FindGameObjectsWithTag("BlackCube");
        Finish = GameObject.FindGameObjectWithTag("Finish");
        Finish.GetComponent<LineActivate>().ReActivate();
        foreach(GameObject LineCube in LineCubes){
            LineCube.GetComponent<LineActivate>().ReActivate();
        }
        foreach(GameObject BlueCube in BlueCubes){
            BlueCube.GetComponent<BlueLine>().ReActivate();
        }
        foreach(GameObject BlackCube in BlackCubes){
            BlackCube.GetComponent<BlackLine>().ReActivate();
        }
    }
}
