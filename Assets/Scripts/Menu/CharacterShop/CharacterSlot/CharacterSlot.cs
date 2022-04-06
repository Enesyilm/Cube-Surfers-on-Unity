using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSlot : MonoBehaviour
{
    
    [SerializeField]
    CharacterPlatform characterPlatform;
    [SerializeField]
    GameObject locked;
    [SerializeField]
    CharacterSO character;
    private void Awake() {
         if(!PlayerPrefs.HasKey(character.characterName+"isLocked"))
         {if(!(character.characterName=="Casual"))PlayerPrefs.SetInt(character.characterName+"isLocked",1);
         else{
             PlayerPrefs.SetInt(character.characterName+"isLocked",0);
         }}
        
    }
    public void SendCharacterInfoPlatform(){
        Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.ButtonSound);
        CharacterPlatform.characterOnPlatform=character;
        characterPlatform.UpdateCharacter();
    }
    
    private void Update() {
        if(PlayerPrefs.GetInt(character.characterName+"isLocked")==1){
            locked.SetActive(true);
        }
        else{
            locked.SetActive(false);
        }
    }
    
}
