using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float RightLeftSpeed;
    [SerializeField]
    private float planeSize;
    public static bool isPlayerDead=false;
    // Start is called before the first frame update
    void OnEnable()
    {
        isPlayerDead=false;
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
        if(!isPlayerDead){
            this.transform.Translate(Mathf.Clamp(horizontalAxis, -planeSize, planeSize), 0, forwardSpeed * Time.deltaTime);
        }
    }

    private float TakeInput()
    {
        return  InputController.HorizontalInput* RightLeftSpeed * Time.deltaTime;
    }
}
