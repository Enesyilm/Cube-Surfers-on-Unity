using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum selectAnimation{
    anim1,
    anim2
}
public class BringSelectedCharacter : MonoBehaviour
{
   
    [SerializeField]
    selectAnimation selectAnimation;
    Animator animator;
    [SerializeField]
    RuntimeAnimatorController[] animatorController;
    [SerializeField]
    Transform spawnPosition;
    [SerializeField]
    SelectedCharacterSO selectedCharacterSO;
     GameObject instantiatedCharacter;
    public bool setScaleBool=false;
    [HideInInspector]
     public float scaleX=1;
    [HideInInspector]
     public float scaleY=1;
    [HideInInspector]
     public float scaleZ=1;
    // Start is called before the first frame update
    private void OnEnable() {
        if(spawnPosition.childCount>0)
        {
            Destroy(spawnPosition.GetChild(0).gameObject);
            InstantiateCharacter();
            animator = instantiatedCharacter.GetComponent<Animator>();
            animator.runtimeAnimatorController = animatorController[Random.Range(0, animatorController.Length)];
        }
        else
        {
            InstantiateCharacter();
            
        }
    }

    private void InstantiateCharacter()
    {
        instantiatedCharacter = Instantiate(selectedCharacterSO.SelectedCharacter.characterModel, spawnPosition.position, Quaternion.identity, spawnPosition);
        SetScale(scaleX,scaleY,scaleZ);
    }

    void SetScale(float x,float y,float z)
    {
        if(setScaleBool){
            instantiatedCharacter.transform.localScale= new Vector3(scaleX,scaleY,scaleZ);}
    }

    // Update is called once per frame
    void Update()
    {
    }
}
