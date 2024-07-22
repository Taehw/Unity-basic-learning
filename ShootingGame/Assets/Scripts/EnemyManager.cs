using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //�ּ� �ð�
    float minTime = 1;
    //�ִ� �ð�
    float maxTime = 5; 

    //����ð�
    float currentTime;
    //�����ð�
    public float createTime = 1;
    //�� ����
    public GameObject enemyFactory;

    void Start()
    {
        //�¾ �� ���� ���� �ð��� �����ϰ�
        createTime = UnityEngine.Random.Range(minTime, maxTime);
    }

    void Update()
    {
        //1. �ð��� �帣�ٰ�
        currentTime += Time.deltaTime;

        //2. ���� ���� �ð��� ���� �ð��� �Ǹ�
        if(currentTime > createTime )
        {
            //3. �� ���忡�� ���� ������
            GameObject enemy = Instantiate( enemyFactory );
            //�� ��ġ�� ���� ���� �ô�.
            enemy.transform.position = transform.position;
            //���� �ð��� 0���� �ʱ�ȭ
            currentTime = 0;
            //���� ������ �� ���� ���� �ð��� �ٽ� �����ϰ� �ʹ�.
            createTime = UnityEngine.Random.Range(minTime, maxTime);

        }
    }
}