using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    public AudioClip cry;
    private AudioSource audioSource;

    IEnumerator PlaySounds()
    {
        yield return new WaitForSeconds(5);
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = cry;
        audioSource.loop = true;
        audioSource.Play();
    }

    void Start()
    {
        StartCoroutine(PlaySounds());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
