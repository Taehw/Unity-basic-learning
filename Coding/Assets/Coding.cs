using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coding : MonoBehaviour
{

    int Plus(int number1, int number2)
    {
        return number1 + number2; 
    }
    // Start is called before the first frame update
    void Start()
    {
        //print("Hello world");

        /* ����
        string text;

        text = "Helloworld";

        print(text);
        */

        /*
         *  
         * ���ǹ� if 
         * 
        int number = 0;

        if(number <= 0)
        {
            print("���� 0���� �۽��ϴ�");
        }

        else if(number >=1 && number <=5)
        {
            print("���� 1~5 �����Դϴ�.");
        }

        else
        {
            print("���� 5���� Ů�ϴ�.");
        }
        */

        /*�ݸ� for */

        /*
        int number = 0;

        for(int i = 0; i < 100; i++)
        {
            number++;
        }
        print(number);
        */

        /* �Լ�(Method) */

        int sum = Plus(2, 10);
        print(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
