using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private readonly string horizontal = "Horizontal";
    private readonly string vertical = "Vertical";

    private bool onGround = true;
    private bool onJumping = false;

    float speed = 2.0f;
    float jumpForce = 6.0f;

    Vector3 moveVector = Vector3.zero;
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

        if (!onJumping && onGround)
        {
            if (Input.GetButton("Jump"))
            {
                moveVector.y = 1 * jumpForce;
                //rigidbody.velocity = new Vector3(0, jumpForce, 0);
                //rigidbody.AddForce(0, jumpForce, 0, ForceMode.Impulse);
                //rigidbody.AddForce(moveVector, ForceMode.Impulse);
                onJumping = true;
            }
        }
        if (_rigidbody.velocity.magnitude < 2.0f)
        {
            _rigidbody.velocity = moveVector;
            //rigidbody.AddForce(moveVector.x, moveVector.y, moveVector.z, ForceMode.Impulse);
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            onGround = true;
            onJumping = false;
        }
    }
}
