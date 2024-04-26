using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : DefaultAnimator
{

    public void IdleAnimation()
    {
        DisableAllAnimations();
    }

    public void WalkAnimation()
    {
        SetAnimationBool("IsWalking", true);
    }

    public void RunAnimation()
    {
        SetAnimationBool("IsRunning", true);
    }

    public void CrawlAnimation()
    {
        SetAnimationBool("IsCrawling", true);
    }

    public void SetMovementVectorValue(Vector2 InputAxis)
    {
        SetFloatValue("x", InputAxis.x);
        SetFloatValue("y", InputAxis.y);
    }

    
    public override void DisableAllAnimations()
    {
        Animator.SetBool("IsWalking", false);
        Animator.SetBool("IsRunning", false);
        Animator.SetBool("IsCrawling", false);
    }
}