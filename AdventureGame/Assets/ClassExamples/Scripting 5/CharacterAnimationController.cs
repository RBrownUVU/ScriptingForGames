using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    
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
       //Triggers the Double Jump Animation
       // if (Input.GetButtonDown("Jump"))
      //  {
      //      animator.SetTrigger("Jump");
       // }
     //   else
     //   {
     //       animator.SetTrigger("Idle");
     //   }

       //Triggers the Hit Animation
        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        //Triggers the Hit Animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }
}
