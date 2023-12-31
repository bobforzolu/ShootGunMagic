using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  State
{
    protected PlayerController controller;
    protected Statemachine statemachine;
    protected bool isExitingState;
    protected float startTime;

    protected State( PlayerController controller, Statemachine statemachine)
    {
        this.controller = controller;
        this.statemachine = statemachine;
    }

    public virtual void Enter() {
        startTime = Time.time;

        isExitingState = false;

    }
    public virtual void Exit()
    {
        isExitingState = true;

    }
    public virtual void Update() {
        controller.PlayerStats.FacingDirection = controller.core.movement.facingDirections;
    }

    public virtual void AbilityFinish()
    {
    }
    public virtual void AnimationEventTrigger()
    {

    }

}
