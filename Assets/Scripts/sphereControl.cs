using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sphereControl : MonoBehaviour
{
    public bool[,] Squares;
    private Vector3 Pos;
    public int xStart;
    public int yStart;
    public int x;
    public int y;
    public bool CanMove = false;
    public GameObject Fin;
    private int LF;
    public Text Lifes;
    public Animator LifesAnim;
    public Animator RestartAnim;
    public Animator TimerAnim;
    public Transform respPoint;
    //public GameObject blackCube;
    public GameObject Cam;
    public bool isFinish = false;
    public string LvlNumber;
    private AudioSource audio;
    public AudioClip moveSound;
    public AudioClip hitSound;
    public AudioClip restartSound;
    public AudioClip finishSound;
    public int MaxS;
    public int MaxC;
    

    void Start(){
        LF = 3;
        Lifes.text = LF.ToString();
        x=xStart;
        y=yStart;
        GetComponent<Lvls>().ChooseLvl(LvlNumber);
        Squares = GetComponent<Lvls>().Squares;
        audio=GetComponent<AudioSource>();
    }
    void Update()
    {
        if(CanMove){
            if(Input.GetKeyDown(KeyCode.W)){
                if(y>0 && Squares[y-1,x]){
                    audio.PlayOneShot(moveSound);
                    Pos = new Vector3(transform.position.x,transform.position.y+1,transform.position.z);
                    transform.position = Pos;
                    y--;
                }else{
                    Hit(1);
                }
            }
            if(Input.GetKeyDown(KeyCode.S)){
                if(y<MaxS && Squares[y+1,x]){
                    audio.PlayOneShot(moveSound);
                    Pos = new Vector3(transform.position.x,transform.position.y-1,transform.position.z);
                    transform.position = Pos;
                    y++;
                }else{
                    Hit(1);
                }
            }
            if(Input.GetKeyDown(KeyCode.A)){
                if(x>0 && Squares[y,x-1]){
                    audio.PlayOneShot(moveSound);
                    Pos = new Vector3(transform.position.x-1,transform.position.y,transform.position.z);
                    transform.position = Pos;
                    x--;
                }else{
                    Hit(1);
                }
            }
            if(Input.GetKeyDown(KeyCode.D)){
                if(x<MaxC && Squares[y,x+1]){
                    audio.PlayOneShot(moveSound);
                    Pos = new Vector3(transform.position.x+1,transform.position.y,transform.position.z);
                    transform.position = Pos;
                    x++;
                }else{
                    Hit(1);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Finish")){
            audio.PlayOneShot(finishSound);
            Cam.GetComponent<Timer>().SaveTime();
            TimerAnim.SetTrigger("TimerTrigger");
            RestartAnim.SetTrigger("RestartTrigger");
            Fin.GetComponent<StartStopProc>().SwapTrue();
            Fin.GetComponent<StartStopProc>().StartStopGame();
            Cam.GetComponent<Timer>().isFinish = true;
            isFinish = true;
        }
        if(other.gameObject.CompareTag("BlackCube")){
            Hit(1);
        }
    }
    public void MoveSwap(){
        CanMove = !CanMove;
    }

    public void Hit(int damage){
        audio.PlayOneShot(hitSound);
        LifesAnim.SetTrigger("HitTrigger");
        LF-=damage;
        Lifes.text = LF.ToString();
        if(LF<0){
            Respawn();
        }
    }

    public void Respawn(){
        transform.position = respPoint.position;
        x=xStart;
        y=yStart;
        LF=3;
        Lifes.text = LF.ToString();
    }

    public void Restart(){
        audio.PlayOneShot(restartSound);
        if(isFinish){
            TimerAnim.SetTrigger("TimerTriggerR");
            RestartAnim.SetTrigger("RestartTriggerR");
        }
        transform.position = respPoint.position;
        x=xStart;
        y=yStart;
        LF=3;
        Lifes.text = LF.ToString();
        if(!isFinish){
            MoveSwap();
        }
        isFinish = false;
    }
}
