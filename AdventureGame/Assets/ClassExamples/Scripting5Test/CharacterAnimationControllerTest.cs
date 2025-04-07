using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationControllerTest : MonoBehaviour
{
    private Animator animator;
    private Vector3 velocity;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("JumpTrigger");
        }
        if (velocity.y < 0)
        {
            animator.SetTrigger("Fall");
        }

    }
    

    
}
