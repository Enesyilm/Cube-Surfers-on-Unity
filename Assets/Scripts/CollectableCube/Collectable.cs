using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
   bool isCollected=false;
   [SerializeField]
   int IncreaseAmount;
   [SerializeField]
    ResourceSystem coinSystem;
   int index;
   public Collector collector;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIsCollected();
    }

    private void CheckIsCollected()
    {
        if (isCollected == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }

    public bool GetIsCollected(){
       
        return isCollected;
    }
    public void MakeCollectedTrue()
    {
        coinSystem.IncreaseCoinAmount(IncreaseAmount);
        PlayJumpSound();
        isCollected = true;
    }

    private static void PlayJumpSound()
    {
        Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.jumpSound);
    }

    public void UpdateIndex(int height){
        this.index=height;
    }
}
