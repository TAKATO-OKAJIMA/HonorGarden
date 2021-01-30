using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private const string isRun = "isRun";
    private const string isJump = "isJump";

    private PlayerController playerController;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool(isRun, playerController.IsRunning());
        animator.SetBool(isJump, playerController.IsJumping());
    }
}
