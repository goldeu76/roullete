using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoulletController : MonoBehaviour
{
    float rotSpeed = 0; //초기값

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //좌클릭을 했을때(모바일은 터치)
        {
            rotSpeed = 10; //룰렛 스피드 조정
        }
        /*if (rotSpeed > 0) //감속1
        {
            rotSpeed = rotSpeed - 0.25f;
        }*/

        transform.Rotate(0,0,rotSpeed);
        //transform.localRotation = Quaternion.Euler(new Vector3(0,0,this.rotSpeed)); 정적 필드
        rotSpeed *= 0.96f; //감속2
    }
}
