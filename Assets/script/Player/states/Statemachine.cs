using Laurence.Game_utilities;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine 
{
    public State CurrentState { get; private set; }
    public BaseState CurrentEnemy { get; private set; }

    public void Intialize( State newState)
    {
        CurrentState = newState;
        CurrentState.Enter();
    }
    public void Intialize(BaseState newState)
    {
        CurrentEnemy = newState;
        CurrentEnemy.Enter();
    }
    public void CangeState(State newState)
    {
        CurrentState.Exit();
        CurrentState = newState;
        CurrentState.Enter();

    }
    public void CangeState(BaseState newState)
    {
        CurrentEnemy.Exit();
        CurrentEnemy = newState;
        CurrentEnemy.Enter();

    }
}
