using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    void Start()
    {
        
    }

    //�÷��̾ �̵��� �ӷ� 
    public float speed = 5;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Vector3 dir = Vector3.right * h + Vector3.up * v;
        Vector3 dir = new Vector3(h, v, 0);

        // transform.Translate(dir * speed * Time.deltaTime); �� P = P0 + vt �������� ����
        // 1��° ���� : transform.position = transform.position + dir * speed * Time.deltaTime; -> �ݺ��Ǵ� ����
        // 2��° ����

        transform.position += dir * speed * Time.deltaTime;
    }
}