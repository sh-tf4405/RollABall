using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // 試験の点数を保存するための5つ容量のある配列を宣言
    int[] testScores = new int[5];

    List<int> testNum = new List<int>();

    List<int> listNumbers = new List<int> {1,2,3,4,5};

    List<string> color = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };
    
    
    
    
    
    void Start()
    {
        // 配列に点数を代入
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;
        Debug.Log(testScores[1]); // 90

        int[] number = { 5, 8, 12, 7, 3 };
        Debug.Log(number[2]);

        string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
        Debug.Log(fruits[2]);

        int[] scores = { 78, 85, 90, 72, 88, 60 };
        int sum = 0;
        foreach(int score in scores)
        {
            sum += score;
        }
        Debug.Log(sum);

        testNum.Add(1); 
        testNum.Add(2); 
        testNum.Add(3); 
        Debug.Log(testNum[0]); 
        testNum.Remove(2); 
        Debug.Log(testNum.Count); 

        foreach(int listNumber in listNumbers)
        {
            Debug.Log(listNumber);
        }

        color.Remove("Green");

        for (int i = 0; i < color.Count; i++)
        {
            Debug.Log(color[i]);
        }
    }


// Update is called once per frame
    void Update()
    {
        
    }
}
