using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //�ʿ�Ӽ� : �̵��ӵ� 
    public float speed = 5;

    //������ ���� ������ ����� Start�� Update���� ���
    Vector3 dir;
    void Start()
    {
        //Vector3 dir; --> ����
        //0���� 9���� 10���� �� �߿� �ϳ��� �������� �����´�.
        int randValue = UnityEngine.Random.Range(0, 10);
        //���� 3���� ������ �÷��̾� ����
        if (randValue < 3)
        {
            //�÷��̾ ã�� target���� �ϰ� �ʹ�
            GameObject target = GameObject.Find("Player");
            //������ ���ϰ� �ʹ�. target-me
            dir = target.transform.position - transform.position;
            //������ ũ�⸦ 1�� �ϰ�ʹ�. -> �����̵� ����
            dir.Normalize();
        }
        else //�׷��� ������ �Ʒ��������� ���ϰ� �ʹ�
        {
            dir = Vector3.down;
        }

    }
    void Update()
    {
        //1.������ ���Ѵ�(���̴ϱ� �Ʒ��� �̵�)
        //Vector3 dir = Vector3.down; --> ����

        //2. �̵��ϰ� �ʹ�. ���� P = P0 + vt
        transform.position += dir * speed * Time.deltaTime;
    }

    //�浹 ����
    private void OnCollisionEnter(Collision other)
    {
        //�� �װ�
        Destroy(other.gameObject);
        //�� ����
        Destroy(gameObject);
    }
}
