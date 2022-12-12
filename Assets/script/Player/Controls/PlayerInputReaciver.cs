using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputReaciver : MonoBehaviour
{
    public PlayerInput input;
    public bool isSwitch { get; private set; }
    public bool isAttack { get; private set; }
    private Vector2 movement;
    private Vector2 rawMovement;
    public int normInputX { get; private set; }

    public int normInputY { get; private set; }
    public bool ReasourceChange { get; private set; }



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




    public void OnRessorcePressed()
    {
        ReasourceChange = false;
    }
    public void OnAttackPressed()
    {
        isAttack = false;
    }

}
