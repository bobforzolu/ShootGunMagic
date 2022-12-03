using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Laurence.script.Player;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerInputReaciver input;
    public  AttackState AttackState { get; private set; }
    public IdleState idleState { get; private set; }
    public WeaponChangeState weaponChange { get; private set; }

    public WepontController wepont;
    private Statemachine statemachine;
    public Animator animator;

    private void Awake()
    {
        
        statemachine = new Statemachine();
        idleState = new IdleState(this, statemachine);
        AttackState = new AttackState(this, statemachine, wepont);
        weaponChange = new WeaponChangeState(this, statemachine);

    }
    void Start()
    {
        statemachine.Intialize(idleState);

    }

    // Update is called once per frame
    void Update()
    {
        statemachine.CurrentState.Update();
        
    }
    public void AbilityFinish()
    {
        statemachine.CurrentState.AbilityFinish();
    }


}
