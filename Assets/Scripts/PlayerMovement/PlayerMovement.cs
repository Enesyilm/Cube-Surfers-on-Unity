using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float deathOffset=3;
    [SerializeField]
    GeneralLevelUI settings;
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float RightLeftSpeed;
    [SerializeField]
    private float planeSize;
    public static bool isPlayerDead=false;
    public static bool isPlayerWinned=false;
     WaitForSec waitForSec;
    // Start is called before the first frame update
    void OnEnable()
    {
        isPlayerDead=false;
    }
    private void Awake() {
        waitForSec=new WaitForSec();
    }
    private void Update() {
         if(PlayerMovement.isPlayerDead){
            if(waitForSec.WaitForSecond(deathOffset)){
                PlayerMovement.isPlayerDead=false;
                settings.OpenRestartPage();

            }
        }
        else if(PlayerMovement.isPlayerWinned){
            if(waitForSec.WaitForSecond(deathOffset)){
                PlayerMovement.isPlayerWinned=false;
                settings.OpenVictoryPage();

            }
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float horizontalAxis = TakeInput();
        MovePlayer(horizontalAxis);
        ClampHorizontalMovement();

    }

    private void ClampHorizontalMovement()
    {
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -planeSize, planeSize);
        transform.position = pos;
    }

    private void MovePlayer(float horizontalAxis)
    {
        if(!isPlayerDead||isPlayerWinned){
            this.transform.Translate(Mathf.Clamp(horizontalAxis, -planeSize, planeSize), 0, forwardSpeed * Time.deltaTime);
        }
    }

    private float TakeInput()
    {
        return  InputController.HorizontalInput* RightLeftSpeed * Time.deltaTime;
    }
}
