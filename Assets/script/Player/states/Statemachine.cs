using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine 
{
    public State CurrentState { get; private set; }

    public void Intialize( State newState)
    {
        CurrentState = newState;
        CurrentState.Enter();
    }
    public void CangeState(State newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();

    }
}
