using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public bool timerActive = false;
    public float timeStart = 0;
    public Text timerText;
    //public Transform target;
    public bool isFinish=false;
    private float thisTime;

    void Start(){
        timerText.text = timeStart.ToString("F2");
    }

    void Update(){
        //transform.LookAt(target);
        if(timerActive){
            timeStart += Time.deltaTime;
            timerText.text = timeStart.ToString("F2");
        }
    }

    public void TimeSwap(){
        timerActive = !timerActive;
    }

    public void TimeToZero(){
        if(!isFinish){
            TimeSwap();
        }
        timeStart = 0;
        timerText.text = timeStart.ToString("F2");
    }

    public void SaveTime(){
        string name = string.Concat(SceneManager.GetActiveScene().name,"float");
        if (PlayerPrefs.HasKey(name)){
            thisTime = PlayerPrefs.GetFloat(name);
            if(thisTime > timeStart){
                PlayerPrefs.SetString(SceneManager.GetActiveScene().name, timeStart.ToString("F2"));
                PlayerPrefs.SetFloat(name, timeStart);
        }
        } else{
            PlayerPrefs.SetString(SceneManager.GetActiveScene().name, timeStart.ToString("F2"));
            PlayerPrefs.SetFloat(name, timeStart);
        }
    }
}
