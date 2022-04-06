using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{   [SerializeField]
    GameObject victoryConfeti;
   [SerializeField]
    PlayerAnimations playerAnimations;
    WaitForSec waitForSec;
    // Start is called before the first frame update
    private void Awake() {
        waitForSec=new WaitForSec();
    }
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("lastopenedlevel arttı");
        if(other.tag=="Player"){
            if(LevelLockSystem.canIncreaseLevel){
                PlayerPrefs.SetInt("LastOpenedLevel",PlayerPrefs.GetInt("LastOpenedLevel")+1);
                
            }
            PlayerMovement.isPlayerWinned=true;
            victoryConfeti.SetActive(true);
            playerAnimations.PlayAnimation("Victory");
             Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.victorySound);
            //  if(waitForSec.WaitForSecond(3)){
            //     SceneManager.LoadScene(0);
            //  }
             

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
