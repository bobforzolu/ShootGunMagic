using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  State
{
    protected PlayerController controller;
    protected Statemachine statemachine;
    protected State( PlayerController controller, Statemachine statemachine)
    {
        this.controller = controller;
        this.statemachine = statemachine;
    }

    public virtual void Enter() { 
    }
    public virtual void Exit()
    {

    }
    public virtual void Update() {
        Debug.Log("hi");
    }

    public virtual void AbilityFinish()
    {
    }

}
