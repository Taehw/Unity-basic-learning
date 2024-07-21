using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //필요 속성 : 이동 속도 
    public float speed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        //1. 방향을 구한다. , 위로 쏘기만 하면 댐 총알은 최종구현을 생각해보면 됨!
        Vector3 dir = Vector3.up;
        //2. 이동하고 싶다. 등속 운동 공식 사용
        transform.position += dir * speed * Time.deltaTime;
    }
}
