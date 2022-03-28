using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringSelectedCharacter : MonoBehaviour
{
    [SerializeField]
    Transform spawnPosition;
    [SerializeField]
    SelectedCharacterSO selectedCharacterSO;
    // Start is called before the first frame update
    private void OnEnable() {
        if(spawnPosition.childCount>0){
            Destroy(spawnPosition.GetChild(0).gameObject);
            GameObject CurrentPlayer=Instantiate(selectedCharacterSO.SelectedCharacter.characterModel, spawnPosition.position,Quaternion.identity,spawnPosition);
        }
        else{
            Instantiate(selectedCharacterSO.SelectedCharacter.characterModel, spawnPosition.position,Quaternion.identity,spawnPosition);
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
