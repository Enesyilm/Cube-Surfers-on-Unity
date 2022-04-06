using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLockSystem : MonoBehaviour
{
    public static  bool canIncreaseLevel=false;
    // Start is called before the first frame update
    void OnEnable()
    { 
        MapLevelNumbers();
        InitializeLockedLevelPref();
    }

    private static void InitializeLockedLevelPref()
    {
        if (!PlayerPrefs.HasKey("LastOpenedLevel")){ PlayerPrefs.SetInt("LastOpenedLevel", 1);}
    }

    private static void IncreaseLastOpenedLevel()
    {
        PlayerPrefs.SetInt("LastOpenedLevel",PlayerPrefs.GetInt("LastOpenedLevel")+1);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void MapLevelNumbers()
    {
        for (int i = 1; i < transform.childCount+1; i++)
        {
            transform.GetChild(i-1).GetComponent<LevelSlot>().levelValue = i;
            transform.GetChild(i-1).GetComponentInChildren<TextMeshProUGUI>().text = "Level "+i;
        }
    }
}
