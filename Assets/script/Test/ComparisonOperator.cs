using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComparisonOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        /*��r���Z�q
        True:
        �^
        False:
        �U*/
        int x = 5;
        int y = 8;
        Debug.Log(x == y); // false
        Debug.Log(x != y); // true
        Debug.Log(x > y); // false
        Debug.Log(x < y); // true
        Debug.Log(x >= y); // false
        Debug.Log(x <= y); // true
        Debug.Log(x > 5); // false
        Debug.Log(x >= 5); // true

        if (x == y) // false
        {
            Debug.Log("x��y�͓������ł�"); // false�̂��ߕ\������Ȃ�
        }
        if (x != y) // true
        {
            Debug.Log("x��y�͓������Ȃ��ł�"); // true�̂��ߕ\�������
        }

        bool trueOrFalse = (x == y); //false
        if (trueOrFalse) // false
        {
            Debug.Log("x��y�͓������ł�"); // false�̂��ߕ\������Ȃ�
        }
        trueOrFalse = (x != y);
        if (trueOrFalse) // true
        {
            Debug.Log("x��y�͓������Ȃ��ł�"); // true�̂��ߕ\�������
        }

        int x1 = 5;
        int y2 = 7;

        if (x > y)
        {
            Debug.Log("x��y��肨������");
        }

        string name1 = "join";
        string name2 = "join";
        if (name1 == name2)
        {
            Debug.Log("2�͓������O�ł�");
        }

        int age = 0;

        if (age >= 20){
            Debug.Log("���l�ł�");
        }else
        {
            Debug.Log("�����N�ł�");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
