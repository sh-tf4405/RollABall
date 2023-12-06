using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameTimer1 : MonoBehaviour
{

    public Text TimerText;

    private float timertimer = 20f;

    public float Gettimer
    {
        get { return timertimer; }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timertimer <= 0)
        {
            TimerText.text = "0";
            timertimer = 0;
        }
    }
}
