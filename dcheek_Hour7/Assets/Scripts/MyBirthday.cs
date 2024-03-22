using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    private int months = 1;
    private int days = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (months <= 12)
        {
            if (months == 1)
            {
                Debug.Log("It's my Birthday month!" + '\n');
            }
            else
            {
                Debug.Log("Months: " + months.ToString() + '\n');
            }
            months++;
        }

        while (days < 31 && months > 12)
        {
            days += 1;
            if (days != 24)
            {
                Debug.Log("January Days: " + days.ToString() + '\n');
            }
            else
            {
                Debug.Log("It's my Birthday!\n");
            }
        }
    }
}
