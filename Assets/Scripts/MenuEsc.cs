using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuEsc : MonoBehaviour
{
    public GameObject fade;
    public GameObject cam;
    public Text bestTime;
    public int LvlNow;

    private void Update(){
        bestTime.text = PlayerPrefs.GetString(SceneManager.GetActiveScene().name, "--,--");
        if(Input.GetKeyDown(KeyCode.M)){
            MainMenu();
        }
        if(Input.GetKeyDown(KeyCode.N)){
            if(LvlNow!=15){
                Next();
            }
        }
        if(Input.GetKeyDown(KeyCode.Q)){
            ExitGame();
        }
        if(Input.GetKeyDown(KeyCode.P)){
            if(LvlNow!=1){
                Prev();
            }
        }
    }

    public void MainMenu(){
        fade.GetComponent<FadeOnLevels>().sceneName = "Main";
        cam.GetComponent<Animator>().SetTrigger("VolumeEnd");
        fade.GetComponent<Animator>().SetTrigger("Fade");
    }

    public void ExitGame(){
        Application.Quit();
    }

    public void Next(){
        LvlNow++;
        string nextLevelName = string.Concat("Lvl", LvlNow.ToString());
        fade.GetComponent<FadeOnLevels>().sceneName = nextLevelName;
        cam.GetComponent<Animator>().SetTrigger("VolumeEnd");
        fade.GetComponent<Animator>().SetTrigger("Fade");
    }

    public void Prev(){
        LvlNow--;
        string nextLevelName = string.Concat("Lvl", LvlNow.ToString());
        fade.GetComponent<FadeOnLevels>().sceneName = nextLevelName;
        cam.GetComponent<Animator>().SetTrigger("VolumeEnd");
        fade.GetComponent<Animator>().SetTrigger("Fade");
    }
}
