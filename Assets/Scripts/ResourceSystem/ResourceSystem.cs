using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ResourceSystem : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI coinText;
    [SerializeField]
    TextMeshProUGUI gemText;
    [SerializeField]
    int initCoinAmount;
    public static int coinAmount;
    public static int gemAmount;



    // public static ResourceSystem Instance;

    // private void InstantiateController() {
    //     if(Instance == null)
    //     {
    //         Instance = this;
    //         DontDestroyOnLoad(this);
    //     }
    //     else if(this != Instance) {
    //         Destroy(this.gameObject);
    //     }
    // }
    private void Awake() {
        if(!PlayerPrefs.HasKey("Gem"))PlayerPrefs.SetInt("Gem",30);
        if(!PlayerPrefs.HasKey("Coin"))PlayerPrefs.SetInt("Coin",1);
        //this.InstantiateController();
        coinText.text=PlayerPrefs.GetInt("Coin").ToString();
        gemText.text=PlayerPrefs.GetInt("Gem").ToString();
    }
    public void IncreaseCoinAmount(int value){
      coinAmount=PlayerPrefs.GetInt("Coin")+value;
      PlayerPrefs.SetInt("Coin",coinAmount);
      coinText.text=PlayerPrefs.GetInt("Coin").ToString();
    
    }
    public void IncreaseGemAmount(int value){
      gemAmount=PlayerPrefs.GetInt("Gem")+value;
      PlayerPrefs.SetInt("Gem",gemAmount);
      gemText.text=PlayerPrefs.GetInt("Gem").ToString();
    
    }
    public void DecreaseGemAmount(int value){
      gemAmount=PlayerPrefs.GetInt("Gem")-value;
      PlayerPrefs.SetInt("Gem",gemAmount);
      gemText.text=PlayerPrefs.GetInt("Gem").ToString();
    
    }
}

