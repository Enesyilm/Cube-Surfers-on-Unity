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
GameObject usingButton;
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
        UpdateCharacter();
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
            Debug.Log("else updatechar");
            Instantiate(selectedCharacterSO.SelectedCharacter.characterModel, spawnPosition.position,Quaternion.identity,spawnPosition);
        }
    }
    void DecideUseOrBuyButton(){
        if(PlayerPrefs.GetInt(characterOnPlatform.characterName+"isLocked")==1){
        buyButton.SetActive(true);
        useButton.SetActive(false);
        }
        else{
        buyButton.SetActive(false);
        useButton.SetActive(true);

        }
    }

    public void CheckPurchasable(){
       
        if(PlayerPrefs.GetInt(characterOnPlatform.characterName+"isLocked")==1){
                if(PlayerPrefs.GetInt("Gem")>=characterOnPlatform.price){
                    //  PlayerPrefs.SetInt("Gem",PlayerPrefs.GetInt("Gem")-characterOnPlatform.price);
                    PlayerPrefs.SetInt(characterOnPlatform.characterName+"isLocked",0);
                    buyButton.SetActive(false);
                    useButton.SetActive(true);
                    resourceSystem.DecreaseGemAmount(characterOnPlatform.price);

                }
                else{
                    //cannot afford Price
                    
                }
            }
        else{
            buyButton.SetActive(false);
            useButton.SetActive(false);
            selectedCharacterSO.SelectedCharacter=characterOnPlatform;
        }
    }

}
