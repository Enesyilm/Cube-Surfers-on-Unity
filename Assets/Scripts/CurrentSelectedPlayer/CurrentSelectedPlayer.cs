using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentSelectedPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject currentCharacterModel;
    [SerializeField]
    SelectedCharacterSO selectedCharacterSO;
    [SerializeField]
    CharacterSO defaultCharacter;
    void OnEnable()
    {
        if(!selectedCharacterSO.SelectedCharacter.characterModel){
            selectedCharacterSO.SelectedCharacter.characterModel=defaultCharacter.characterModel;
        }
        currentCharacterModel =selectedCharacterSO.SelectedCharacter.characterModel;
        if(transform.childCount>=1){
            Destroy(transform.GetChild(0));
            GameObject currentCharacterModelInstance=Instantiate(currentCharacterModel,transform.position,Quaternion.identity,transform);
            currentCharacterModelInstance.transform.localScale=new Vector3(.5f,.5f,.5f);
            currentCharacterModelInstance.transform.localPosition=new Vector3(0f,-.5f,0f);
        }
        else{
            GameObject currentCharacterModelInstance=Instantiate(currentCharacterModel,transform.position,Quaternion.identity,transform);
            currentCharacterModelInstance.transform.localScale=new Vector3(.5f,.5f,.5f);
            currentCharacterModelInstance.transform.localPosition=new Vector3(0f,-.5f,0f);
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
