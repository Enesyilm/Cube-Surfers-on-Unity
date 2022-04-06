using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Soundplayer : MonoBehaviour
{
    
    // Start is called before the first frame update
    [SerializeField] public AudioClip jumpSound;
    [SerializeField] public AudioClip victorySound;
    [SerializeField] public AudioClip deathSound;
    [SerializeField] public AudioClip gemCollectSound;
    [SerializeField] public AudioClip ButtonSound;
    [SerializeField] public AudioClip characterSlotSound;
    [SerializeField] public AudioClip heightReduceSound;
    public static Soundplayer soundPlayerInstance;
    [SerializeField] AudioSource audioSource;
    private void Awake() {        
        if(soundPlayerInstance!=null){
            Destroy(this);
        }
        else{
            soundPlayerInstance=this;
            DontDestroyOnLoad(gameObject);
        }
        
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound(AudioClip clip){
        audioSource=audioSource??gameObject.AddComponent<AudioSource>();
        audioSource.clip=clip;
        audioSource.Play();
    }
}
