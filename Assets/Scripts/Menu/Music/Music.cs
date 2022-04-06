using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField]
    GameObject musicClosedIcon;
    private void Awake() {
        if(!PlayerPrefs.HasKey("MusicState"))PlayerPrefs.SetInt("MusicState",1);
        DecideMusicButtonStatus();
    }
   public void OpenCloseMusic(){
        if(PlayerPrefs.GetInt("MusicState")==1){
            PlayerPrefs.SetInt("MusicState",0);
            AudioListener.pause=true;
            musicClosedIcon.SetActive(true);
        }
        else{
            PlayerPrefs.SetInt("MusicState",1);
            AudioListener.pause=false;
            musicClosedIcon.SetActive(false);

        }
        

    }
    public void DecideMusicButtonStatus(){
        if(PlayerPrefs.GetInt("MusicState")==0){
            AudioListener.pause=true;
            musicClosedIcon.SetActive(true);
        }
        else{
            AudioListener.pause=false;
            musicClosedIcon.SetActive(false);

        }
    }
}
