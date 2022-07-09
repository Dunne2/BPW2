using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockAnimation : MonoBehaviour
{
    public Animator animator;
    bool PressedBefore = false;

    public void StartAnimation()
    {
        AnimationHandler();
    }

    public void AnimationHandler()
    {
        if (PressedBefore)
        {
            animator.SetBool("WallForward", false);
            PressedBefore = false;
        }
        else
        {

            animator.SetBool("WallForward", true);
            PressedBefore = true;
        }
    }
}
