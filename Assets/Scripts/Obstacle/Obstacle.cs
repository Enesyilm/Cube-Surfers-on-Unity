using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    
    
    [SerializeField]
    Collector collector;
    [SerializeField]
    PlayerAnimations playerAnimations;
    private void Awake() {
    }
   void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="Player"){
            Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.deathSound);
            PlayerMovement.isPlayerDead=true;            
            playerAnimations.PlayAnimation("Defeat");
            
        }
        else if(other.gameObject.tag=="Collectable"){
            collector.heightReduce();
            other.transform.parent=null;
            GetComponent<BoxCollider>().enabled=false;
            other.gameObject.GetComponent<BoxCollider>().enabled=false;
             Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.heightReduceSound);
            playerAnimations.PlayAnimation("Roll");
            
        }
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
