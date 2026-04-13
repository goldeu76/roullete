using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulletController : MonoBehaviour
{
    // Start is called before the first frame update
    float rotSpeed = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
        }
        /*if (rotSpeed > 0)
        {
            rotSpeed = rotSpeed - 0.25f;
        }*/

        transform.Rotate(0,0,rotSpeed);
        //transform.localRotation = Quaternion.Euler(new Vector3(0,0,this.rotSpeed)); 정적 필드
        rotSpeed *= 0.96f;
    }
}
