using System;
using UnityEngine;


public class DefaultAnimator : MonoBehaviour
{
    [field: SerializeField] public Animator Animator { get; private set; }

   
    public virtual void SetAnimationBool(string name, bool value)
    {
        DisableAllAnimations();
        Animator.SetBool(name, value);
    }

    public virtual void SetFloatValue(string name, float value)
    {
        Animator.SetFloat(name, value);
    }
    
    public virtual void DisableAllAnimations(){}
}