using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaosGoalScript : MonoBehaviour
{
    public bool isSolved = false;
    private int count = 0;

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;
        if (collidedWith.tag == gameObject.tag)
        {
            count += 1;
            Destroy(collidedWith);
            if (count >= 5)
            { 
                isSolved = true;
                GetComponent<Light>().enabled = false;
            }
        }
    }
}
