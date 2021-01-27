using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldPlayerController : MonoBehaviour
{
    public float speed = 3.0f;
    public float jumpSpeed = 8.0f;
    private float gravity;

    private readonly string horizontal = "Horizontal";
    private readonly string vertical = "Vertical";

    private float moveX = 0f;
    private float moveY = 0f;
    private float moveZ = 0f;

    private CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        gravity = Mathf.Abs(Physics.gravity.y);
        moveDirection.y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis(horizontal);
        moveZ = Input.GetAxis(vertical);
        moveY = moveDirection.y;

        moveDirection = new Vector3(moveX, 0, moveZ);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
       
        if (characterController.isGrounded)
        {
            if (Input.GetButton("Jump"))
                moveDirection.y += jumpSpeed;
        }
        else
        {
            moveDirection.y = moveY;
        }
        
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
