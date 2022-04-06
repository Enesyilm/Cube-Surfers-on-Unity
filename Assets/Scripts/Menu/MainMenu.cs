using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int selectedLevel;
    [SerializeField]
    GameObject levelPage;
    [SerializeField]
    GameObject shopPage;
    [SerializeField]
    GameObject mainMenuPage;
    // Start is called before the first frame update
    private void Awake() {
        if (!PlayerPrefs.HasKey("LastOpenedLevel")){ PlayerPrefs.SetInt("LastOpenedLevel", 1);}
    }
    void Start()
    {
        
    }
    public void StartGame(){
        Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.ButtonSound);
        LevelLockSystem.canIncreaseLevel=true;
        SceneManager.LoadScene(PlayerPrefs.GetInt("LastOpenedLevel"));
    }
    public void SelectLevelPage()
    {
    Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.ButtonSound);
    levelPage.SetActive(true);    
    mainMenuPage.SetActive(false);    
    shopPage.SetActive(false);    
    }
    public void SelectShopPage()
    {
    Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.ButtonSound);
    shopPage.SetActive(true);    
    mainMenuPage.SetActive(false);    
    levelPage.SetActive(false);    
    }
    public void SelectMainPage()
    {
    Soundplayer.soundPlayerInstance.PlaySound(Soundplayer.soundPlayerInstance.ButtonSound);
    shopPage.SetActive(false);    
    mainMenuPage.SetActive(true);    
    levelPage.SetActive(false);    
    }
    public void CheckLevelSlot()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
