using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            //Spawns 10 in same position
            //Instantiate(prefab, transform.position, transform.rotation);

            //Spawns 10 in a line
            Instantiate(prefab, new Vector3(i * 2.0f, -3.91f, -8.182909f), transform.rotation);
        }
    }

    void Update()
    {
        // Whenever we hit the B key we will generate a prefab at the
        // position of the original prefab
        // Whenever we hit the space key, we will generate a prefab at the
        // position of the spawn object that this script is attached to
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }

}
