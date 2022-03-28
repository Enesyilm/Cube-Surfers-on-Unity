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
    public void SendCharacterInfoPlatform(){
        CharacterPlatform.characterOnPlatform=character;
        characterPlatform.UpdateCharacter();
    }
    
    private void Update() {
        if(character.IsLocked==true){
            locked.SetActive(true);
        }
        else{
            locked.SetActive(false);
        }
    }
    
}
