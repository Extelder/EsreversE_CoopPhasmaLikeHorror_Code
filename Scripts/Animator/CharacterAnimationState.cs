using UnityEngine;


public abstract class CharacterAnimationState : State
{
    [field: SerializeField] public CharacterAnimator Animator { get; private set; }
    
    public abstract override void Enter();
}