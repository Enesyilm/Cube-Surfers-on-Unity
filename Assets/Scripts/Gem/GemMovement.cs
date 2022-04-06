using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemMovement : MonoBehaviour
{
    Vector3 pos;
    [SerializeField]
    float speed = 2f;
    float newY;
    private Color[] colors = new Color[] {Color.red, Color.blue, Color.yellow, Color.white, Color.magenta, Color.green };
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        RotateGem();
        UpDownGem();
    }
    private void RotateGem()
        {
            transform.Rotate(new Vector3(0, 1, 0), Space.World);
        }
    private void UpDownGem()
    {
            newY=0;
            newY= Mathf.Sin(Time.time * speed)/2+pos.y;

            //set the object's Y to the new calculated Y
            transform.position = new Vector3(pos.x, newY,pos.z) ;
    }
}
