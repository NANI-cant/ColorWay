using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int lvlNumber = 0;
    public string level;
    private Vector2 Pos;
    public RectTransform rect;
    public Text mainBestTime;
    public GameObject[] Lvls;
    public RectTransform[] LvlsRect;
    private AudioSource audio;
    public AudioClip pickSound;
    public GameObject fade;
    public GameObject cam;

    void Start(){
        audio = GetComponent<AudioSource>();
        LoadBestTime(lvlNumber);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) && lvlNumber>0){
            audio.PlayOneShot(pickSound);
            //Pos = new Vector2(rect.anchoredPosition.x,rect.anchoredPosition.y-123);
            Pos = new Vector2(rect.anchoredPosition.x,rect.anchoredPosition.y-306);
            rect.anchoredPosition = Pos;
            //SlideBack();
            DisableLvl();
            lvlNumber--;
            LoadBestTime(lvlNumber);
            //SlideFront();
            EnableLvl();
        }
        if(Input.GetKeyDown(KeyCode.S) && lvlNumber<14){
            audio.PlayOneShot(pickSound);
            //Pos = new Vector2(rect.anchoredPosition.x,rect.anchoredPosition.y+123);
            Pos = new Vector2(rect.anchoredPosition.x,rect.anchoredPosition.y+306);
            rect.anchoredPosition = Pos;
            //SlideBack();
            DisableLvl();
            lvlNumber++;
            LoadBestTime(lvlNumber);
            //SlideFront();
            EnableLvl();
        }

        if(Input.GetKeyDown(KeyCode.E)){
            fade.GetComponent<FadeScript>().lvlNumber = lvlNumber;
            cam.GetComponent<Animator>().SetTrigger("VolumeEnd");
            FadeScene();
            //LoadScene(lvlNumber+1);
        }
    }

    public void ExitGame(){
        Application.Quit();
    }

    private void FadeScene(){
        fade.GetComponent<Animator>().SetTrigger("Fade");
    }

    private void EnableLvl(){
        Lvls[lvlNumber].GetComponent<Lvl>().EnableLevel();
    }
    private void DisableLvl(){
        Lvls[lvlNumber].GetComponent<Lvl>().DisableLevel();
    }

    //private void SlideBack(){
    //    Pos = new Vector2(LvlsRect[lvlNumber].anchoredPosition.x+100,LvlsRect[lvlNumber].anchoredPosition.y);
    //    LvlsRect[lvlNumber].anchoredPosition = Pos;
    //}

    //private void SlideFront(){
    //    Pos = new Vector2(LvlsRect[lvlNumber].anchoredPosition.x-100,LvlsRect[lvlNumber].anchoredPosition.y);
    //    LvlsRect[lvlNumber].anchoredPosition = Pos;
    //}

    private void LoadBestTime(int lvlN){
        mainBestTime.text = Lvls[lvlN].GetComponent<Lvl>().bestTime;
        //mainBestTime.text = PlayerPrefs.GetString(gameObject.name, "--,--");
    }
    private void LoadScene(int lvlN){
        level = string.Concat("Lvl", lvlN.ToString());
        SceneManager.LoadScene(level);
    }
}
