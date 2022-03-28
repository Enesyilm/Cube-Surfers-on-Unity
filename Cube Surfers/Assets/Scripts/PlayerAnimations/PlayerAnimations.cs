using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    Animator animator;
    private void OnEnable() {
        animator=gameObject.GetComponentInChildren<Animator>();
        
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

    public void JumpAnimation()
    {
        animator.SetTrigger("Jump");
    }
    public void RunAnimation()
    {
        animator.SetTrigger("Run");
    }
    public void RollAnimation()
    {
        animator.SetTrigger("Roll");
    }
    public void DefeatAnimation()
    {
        animator.SetTrigger("Defeat");
    }
}
