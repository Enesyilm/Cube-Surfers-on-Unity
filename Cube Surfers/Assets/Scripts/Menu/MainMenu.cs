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
    void Start()
    {
        
    }
    public void StartGame(){
        SceneManager.LoadScene(PlayerPrefs.GetInt("SelectedLevel",1));
    }
    public void SelectLevelPage()
    {
    levelPage.SetActive(true);    
    mainMenuPage.SetActive(false);    
    shopPage.SetActive(false);    
    }
    public void SelectShopPage()
    {
    shopPage.SetActive(true);    
    mainMenuPage.SetActive(false);    
    levelPage.SetActive(false);    
    }
    public void SelectMainPage()
    {
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
