using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSlot : MonoBehaviour
{
    [SerializeField]
    GameObject lockUI;
    [SerializeField]
    public int levelValue=1;
    private void OnEnable() {
        CheckThisLevelIsLocked();
    }
    public void OpenSelectedLevel(){
        if(PlayerPrefs.GetInt("LastOpenedLevel")>=levelValue)
        {
            //Application.LoadLevel(Application.loadedLevel);
            SceneManager.LoadScene(levelValue);
            

        }
        else
        {
            //cant open this level
        }
    }

    private void CheckThisLevelIsLocked()
    {
        if(PlayerPrefs.GetInt("LastOpenedLevel")>=levelValue)
        {
            lockUI.SetActive(false);
        }
        else
        {
            lockUI.SetActive(true);
            //cant open this level
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
