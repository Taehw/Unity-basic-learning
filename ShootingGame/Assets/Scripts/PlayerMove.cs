using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Start()
    {
        
    }

    //플레이어가 이동할 속력 
    public float speed = 5;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);

        // transform.Translate(dir * speed * Time.deltaTime); 를 P = P0 + vt 공식으로 변경
        // 1번째 수정 : transform.position = transform.position + dir * speed * Time.deltaTime; -> 반복되는 내용
        // 2번째 수정

        transform.position += dir * speed * Time.deltaTime;
    }
}