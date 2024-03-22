using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2.0f;
    private int direction = 1;
    private bool stop = false;

    void Start()
    {
        StartCoroutine(ChangeDirectionCoroutine());
    }

    void Update()
    {
        if (stop == false)
        {
            transform.Translate(Vector3.up * direction * speed * Time.deltaTime);
        }
    }

    IEnumerator ChangeDirectionCoroutine()
    {
        while (true)
        {
            if (direction == 1)
            {
                stop = true;
                yield return new WaitForSeconds(5);
            }
            stop = false;
            direction *= -1; 
            yield return new WaitForSeconds(5); 
        }
    }
}
