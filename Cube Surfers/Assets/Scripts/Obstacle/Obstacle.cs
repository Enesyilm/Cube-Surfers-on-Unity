using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    WaitForSec waitForSec;
    [SerializeField]
    float deathOffset=3;
    [SerializeField]
    GeneralLevelUI settings;
    [SerializeField]
    Collector collector;
    [SerializeField]
    PlayerAnimations playerAnimations;
    private void Awake() {
        waitForSec=new WaitForSec();
    }
   void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Collectable"){
            collector.heightReduce();
            other.transform.parent=null;
            GetComponent<BoxCollider>().enabled=false;
            other.gameObject.GetComponent<BoxCollider>().enabled=false;
            playerAnimations.RollAnimation();
            
        }
        else if(other.gameObject.tag=="Player"){
            PlayerMovement.isPlayerDead=true;            
            playerAnimations.DefeatAnimation();
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerMovement.isPlayerDead){
            if(waitForSec.WaitForSecond(deathOffset)){
                PlayerMovement.isPlayerDead=false;
                settings.OpenRestartPage();

            }
        }
    }
}
