using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //�ʿ� �Ӽ� : �̵� �ӵ� 
    public float speed = 5;
    void Start()
    {
        
    }

    void Update()
    {
        //1. ������ ���Ѵ�. , ���� ��⸸ �ϸ� �� �Ѿ��� ���������� �����غ��� ��!
        Vector3 dir = Vector3.up;
        //2. �̵��ϰ� �ʹ�. ��� � ���� ���
        transform.position += dir * speed * Time.deltaTime;
    }
}
