using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
public class PlayerInputReaciver : MonoBehaviour
{
    public PlayerInput input;
    public bool isSwitch { get; private set; }
    public bool isAttack { get; private set; }
    private Vector2 movement;
    private Vector2 rawMovement;
    public int normInputX { get; private set; }
    public Vector2 RawDashDirection { get; private set; }
    public Vector2Int DashDirectionInput { get; private set; }
    public int normInputY { get; private set; }
    public bool ReasourceChange { get; private set; }
    private float jummpInputStartTime;
    public bool DashInput { get; private set; }
    public bool JumpInput { get; private set; }

    private float DashInputStartTime;

    private float inputHoldTime = 0.1f;

    private void Update()
    {
        InputholdtimeAll();
        checkDashInputHoldTime();

    }

    public void OnWeponSwitchPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isSwitch = true;
        }else if (context.canceled)
        {
            isSwitch = false;
        }
    }
    public void OnWeaponSkillChange(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            ReasourceChange = true;
        }
        else if (context.canceled)
        {
            ReasourceChange = false;
        }
    }
    public void OnAttackPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isAttack = true;
        }
        else if (context.canceled)
        {
            isAttack = false;
        }
    }

    public void MovementDirection(InputAction.CallbackContext context)
    {
        rawMovement = context.ReadValue<Vector2>();
        normInputX = (int)(rawMovement * Vector2.right).normalized.x;
        normInputY = (int)(rawMovement * Vector2.up).normalized.y;
        movement = new Vector2(normInputX, normInputY);
    }
    public void OnJumpInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            JumpInput = true;
            jummpInputStartTime = Time.time;
        }
     

    }
    public void onDashInput(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            DashInput = true;
            DashInputStartTime = Time.time;
        }


    }
    public void OnDashDirectionInput(InputAction.CallbackContext context)
    {
        RawDashDirection = context.ReadValue<Vector2>();

        DashDirectionInput = Vector2Int.RoundToInt(RawDashDirection.normalized);

    }

    public void checkDashInputHoldTime()
    {
        if (Time.time >= DashInputStartTime + inputHoldTime)
        {
            DashInput = false;
        }
    }
    private void InputholdtimeAll()
    {
        if (Time.time > jummpInputStartTime + inputHoldTime)
        {
            JumpInput = false;

        }

    }

    public void OnRessorcePressed()
    {
        ReasourceChange = false;
    }
    public void OnAttackPressed()
    {
        isAttack = false;
    }
    public void UseDashInput() => DashInput = false;
    public void Jump_Is_Pressed() => JumpInput = false;


}
