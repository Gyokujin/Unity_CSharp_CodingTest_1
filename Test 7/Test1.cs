using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    // 숫자를 변수에 넣고, 그 수가 양수인지, 음수인지, 0인지 출력하는 프로그램

    int num1 = 15;
    int num2 = -48;
    int num3 = 0;

    void Start()
    {
        Solution(num1);
        Solution(num2);
        Solution(num3);
    }

    string Solution(int num)
    {
        string answer = "";

        if (num > 0)
        {
            answer = "양수";
        }
        else if (num < 0)
        {
            answer = "음수";
        }
        else
        {
            answer = "0";
        }

        Debug.Log(answer);
        return answer;
    }
}