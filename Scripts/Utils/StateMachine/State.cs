using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{
    public bool CanBeingChanged { get; set; } = true;
    
    public abstract void Enter();

    public virtual void Exit() { }
}
