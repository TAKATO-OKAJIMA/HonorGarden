using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly string horizontal = "Horizontal";
    private readonly string vertical = "Vertical";
    private readonly float speed = 2.0f;
    private readonly float jumpForce = 6.0f;

    private bool onGround = true;
    private bool onJumping = false;

    private Vector3 moveVector = Vector3.zero;
    private Vector3 forward = Vector3.zero;
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        moveVector.x = Input.GetAxis(horizontal) * speed;
        moveVector.z = Input.GetAxis(vertical) * speed;
        moveVector.y = _rigidbody.velocity.y;

        forward.x = moveVector.x;
        forward.z = moveVector.z;

        if (!onJumping && onGround)
        {
            if (Input.GetButton("Jump"))
            {
                moveVector.y = 1 * jumpForce;
                onJumping = true;
            }
        }

        if (IsRunning())
        {
            transform.rotation = Quaternion.LookRotation(forward);
        }
        if (_rigidbody.velocity.magnitude < 2.0f)
        {
            _rigidbody.velocity = moveVector;

        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            onGround = true;
            onJumping = false;
        }
    }

    public bool IsRunning()
    {
        return moveVector.x != 0 || moveVector.z != 0;
    }

    public bool IsJumping()
    {
        return onJumping;
    }
}
