using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringConcatenation : MonoBehaviour
{
    string name = "John";
    int age = 20;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("My name is John. " + "I'm 20 years old."); // .�̌�ɃX�y�[�X������
        Debug.Log("My name is John." + " I'm 20 years old."); // I�̑O�ɃX�y�[�X������
        Debug.Log("My name is John." +""+ " I'm 20 years old."); //�X�y�[�X�����̕������A�����Ă���


        Debug.Log("My name is John." + "I'm 20 years old.");

        // �ϐ����g�p����������A��
        Debug.Log("My name is " + name + ". " + "I'm " + age + " years old.");

        // ������⊮
        Debug.Log($"My name is {name}. I'm {age} years old.");

        // string.Format
        Debug.Log(string.Format("My name is {0}. I'm {1} years old.", name, age));

        // double�^����int�^�֕ϊ�
        int x = (int)20.9;
        Debug.Log(x); // 20

        // string�^����int�^�֕ϊ�
        int y = int.Parse("123");
        Debug.Log(y); // 123

       
    }

   
}
