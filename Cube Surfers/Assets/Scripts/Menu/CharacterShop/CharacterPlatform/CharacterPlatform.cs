using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPlatform : MonoBehaviour
{
[SerializeField]
ResourceSystem resourceSystem;
[SerializeField]
GameObject buyButton;
[SerializeField]
GameObject useButton;
[SerializeField]
SelectedCharacterSO selectedCharacterSO;

[SerializeField]
public static CharacterSO characterOnPlatform;
[SerializeField]
Transform spawnPosition;

    private void OnEnable() {
        if(characterOnPlatform==null){
            characterOnPlatform=selectedCharacterSO.SelectedCharacter;
            UpdateCharacter();
        }
    }
    void Update()
    {
        
    }

    public void UpdateCharacter()
    {   DecideUseOrBuyButton();
        if(spawnPosition.childCount>0){
            Destroy(spawnPosition.GetChild(0).gameObject);
            Instantiate(characterOnPlatform.characterModel, spawnPosition.position,Quaternion.identity,spawnPosition);
        }
        else{
            Instantiate(characterOnPlatform.characterModel, spawnPosition.position,Quaternion.identity,spawnPosition);
        }
    }
    void DecideUseOrBuyButton(){
        if(characterOnPlatform.IsLocked){
        buyButton.SetActive(true);
        useButton.SetActive(false);
        }
        else{
        buyButton.SetActive(false);
        useButton.SetActive(true);

        }
    }

    public void CheckPurchasable(){
    if(characterOnPlatform.IsLocked){
             if(PlayerPrefs.GetInt("Gem")>characterOnPlatform.price){
                //  PlayerPrefs.SetInt("Gem",PlayerPrefs.GetInt("Gem")-characterOnPlatform.price);
                 characterOnPlatform.IsLocked=false;
                 buyButton.SetActive(false);
                 useButton.SetActive(true);
                 resourceSystem.DecreaseGemAmount(characterOnPlatform.price);

             }
             else{
                 //cannot afford Price
             }
         }
    else{
        selectedCharacterSO.SelectedCharacter=characterOnPlatform;
    }
    }

}
