using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public State CurrentState { get; private set; }

    public StateMachine(State initialState)
    {
        Init(initialState);
    }

    public void ChangeState(State state)
    {
        if (CurrentState != state && CurrentState.CanBeingChanged == true)
        {
            CurrentState.Exit();
            CurrentState = state;
            CurrentState.Enter();
        }
    }

    public void Init(State initialState)
    {
        CurrentState = initialState;
        CurrentState.Enter();
    }
}
