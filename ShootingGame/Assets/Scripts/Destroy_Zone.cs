using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Zone : MonoBehaviour
{
    //���� �ȿ� �ٸ� ��ü�� ������ ���
    private void OnTriggerEnter(Collider other)
    {
        //�� ��ü�� ���ְ� �ʹ�
        Destroy(other.gameObject);
    }
}
