using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public int lvlNumber = 0;
    public string level;
    public void OnFadeEnd(){
        LoadScene(lvlNumber+1);
    }
    private void LoadScene(int lvlN){
        level = string.Concat("Lvl", lvlN.ToString());
        SceneManager.LoadScene(level);
    }
}
