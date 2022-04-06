using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject MainCube;
    [SerializeField]
    PlayerAnimations playerAnimations;
    int height;
    // Start is called before the first frame update
    private void Awake() {
    }
    void Start()
    {
        MainCube=GameObject.FindGameObjectWithTag("MainCube");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LerpMovement();

        UpdateCollectorHeight();

    }

    private void LerpMovement()
    {
        Vector3 newPosition=new Vector3(transform.position.x, height+1, transform.position.z);
        // Vector3.MoveTowards(MainCube.transform.position,newPosition,1f);
        //MainCube.transform.position = new Vector3(transform.position.x, height+1, transform.position.z);;
        MainCube.transform.position =Vector3.Lerp(MainCube.transform.position,newPosition,.1f);
        //MainCube.transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y,height+1,1f), transform.position.z);
        
    }

    private void UpdateCollectorHeight()
    {
        this.gameObject.transform.localPosition = new Vector3(0, -height, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        CheckIsCollectable(other);
    }

    private void CheckIsCollectable(Collider other)
    {
        if (other.gameObject.tag == "Collectable" && other.gameObject.GetComponent<Collectable>().GetIsCollected() == false)
        {
            height += 1;
            other.gameObject.GetComponent<Collectable>().MakeCollectedTrue();
            other.gameObject.GetComponent<Collectable>().UpdateIndex(height);
            other.gameObject.transform.parent = MainCube.transform;
            playerAnimations.PlayAnimation("Jump");

        }
    }

    public void heightReduce(){
        height--;
        Debug.Log("heightReduce çalıştı"+height);
        if(height==0){
             playerAnimations.PlayAnimation("Run");
        }
    }
}
