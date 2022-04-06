using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;
    public static PlayerAnimations playerAnimationsInstance;
    private void OnEnable() {
        animator=gameObject.GetComponentInChildren<Animator>();
        
    }
    private void Awake() {
        if(playerAnimationsInstance!=null){
            Destroy(this);
        }
        else{
            playerAnimationsInstance=this;
            DontDestroyOnLoad(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        animator=gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PlayAnimation(string triggerName)
    {
        animator.SetTrigger(triggerName);
    }
}
