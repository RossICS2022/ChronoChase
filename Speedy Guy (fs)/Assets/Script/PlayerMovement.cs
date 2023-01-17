using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;

    public float moveSpeed;

    private float horizontalInput;
    private float verticalInput;

    public Transform orientation;

    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
        playerRb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        playerRb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);
    }
}
