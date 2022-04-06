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
    void Start() {
        CheckThisLevelIsLocked();
    }
    public void OpenSelectedLevel()
    {
        PlayButtonSound();
        if (PlayerPrefs.GetInt("LastOpenedLevel") > levelValue)
        {
            //Application.LoadLevel(Application.loadedLevel);
            IsLoadingSceneLastLevel(false);

        }
        else if (PlayerPrefs.GetInt("LastOpenedLevel") == levelValue)
        {
            IsLoadingSceneLastLevel(true);
        }
    }

    private void IsLoadingSceneLastLevel(bool answer)
    {
        LevelLockSystem.canIncreaseLevel = answer;
        SceneManager.LoadScene(levelValue);
    }

    private static void PlayButtonSound()
    {
        Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.ButtonSound);
    }

    private void CheckThisLevelIsLocked()
    {   PlayButtonSound();
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

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
