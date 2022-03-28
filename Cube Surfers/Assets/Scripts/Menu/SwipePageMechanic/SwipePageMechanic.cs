using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipePageMechanic : MonoBehaviour
{
    [SerializeField]
    int pageSize;
    int currentPage=0;
    [SerializeField]
    GameObject[] slotList;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void SwipeToOtherPage()
    {
        Debug.Log(("(transform.childCount/pageSize)1"+(transform.childCount/pageSize)));
        if(currentPage<(transform.childCount/pageSize)){
            currentPage++;

        }
        else{
            currentPage=0;
        }
        for (int index = 0; index < transform.childCount; index++)
        {
            
            if(index>= pageSize*(currentPage)&&index < pageSize*(currentPage+1)){
                transform.GetChild(index).gameObject.SetActive(true);
                Debug.Log("SwipeToOtherPage if Çalıştı");

            }
            else{
                transform.GetChild(index).gameObject.SetActive(false);
            }
        }
        // for (int i = pageSize*(currentPage); i < pageSize*(currentPage+1); i++)
        // {
        //     slotList[i].SetActive(true);
        // }
        
    }
}
