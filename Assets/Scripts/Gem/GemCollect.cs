using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemCollect : MonoBehaviour
{   [SerializeField]
    ResourceSystem resourceSystem;
    [SerializeField]
    int AmountPerTakeGem=1;
    private void Update() {
    }
    void OnTriggerEnter(Collider other) {
        Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.gemCollectSound);
        resourceSystem.IncreaseGemAmount(AmountPerTakeGem);
        Destroy(gameObject);
    }

    
}
