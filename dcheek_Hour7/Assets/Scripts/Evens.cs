using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    private int num = 22;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (num <= 100)
        { 
            if (num % 2 == 0)
            {
                Debug.Log("Even Numbers: " + num.ToString() + '\n');
            }
        num++;
        }
    }
}
