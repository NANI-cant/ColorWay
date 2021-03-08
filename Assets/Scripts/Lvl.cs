using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Lvl : MonoBehaviour
{
    //public Text bestTime;
    public string bestTime;
    public GameObject RedPanel;
    public Text LevelNumber;
    private GameObject bestTimeObj;

    private void Start(){
        //bestTimeObj = GameObject.Find("Levels/gameObject.name/BestTime");
        //bestTime = bestTimeObj.GetComponent<Text>();
        //bestTime.text = PlayerPrefs.GetString(gameObject.name, "--,--");
        bestTime = PlayerPrefs.GetString(gameObject.name, "--,--");
    }

    public void EnableLevel(){
        RedPanel.SetActive(true);
        LevelNumber.color = Color.white;
    }

    public void DisableLevel(){
        RedPanel.SetActive(false);
        LevelNumber.color = Color.black;
    }
}
