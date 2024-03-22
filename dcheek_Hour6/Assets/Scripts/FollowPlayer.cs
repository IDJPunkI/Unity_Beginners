using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public string playerTag = "Player";
    private Transform playerTransform;
    public float followSpeed = 5f;
    public float rotationSpeed = 5f;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag(playerTag);
        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogError("Player object with tag " + playerTag + " not found!");
        }
    }

    void Update()
    {
        if (playerTransform != null)
        {
            Vector3 targetPosition = new Vector3(playerTransform.position.x, playerTransform.position.y, playerTransform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, followSpeed * Time.deltaTime);
            
            Vector3 direction = playerTransform.position - transform.position;
            Quaternion targetRotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}