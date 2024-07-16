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

        /* 변수
        string text;

        text = "Helloworld";

        print(text);
        */

        /*
         *  
         * 조건문 if 
         * 
        int number = 0;

        if(number <= 0)
        {
            print("값이 0보다 작습니다");
        }

        else if(number >=1 && number <=5)
        {
            print("값은 1~5 사이입니다.");
        }

        else
        {
            print("값이 5보다 큽니다.");
        }
        */

        /*반목문 for */

        /*
        int number = 0;

        for(int i = 0; i < 100; i++)
        {
            number++;
        }
        print(number);
        */

        /* 함수(Method) */

        int sum = Plus(2, 10);
        print(sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
