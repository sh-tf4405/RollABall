using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringUtility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static string SecondsToTwoDecimalPlaces(float time)
    {
        return time.ToString("F2");
    }

}
