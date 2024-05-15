using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        // Get a reference to the animator
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Input.GetAxis("Vertical"));
        anim.SetFloat("Direction", Input.GetAxis("Horizontal"));

        Debug.Log("Vertical Input: " + verticalInput + ", Horizontal Input: " + horizontalInput);

    }
}
