using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using Laurence;

public class WepontController : MonoBehaviour
{
    public Weapon Currentweapon;

    public delegate void SwitchWwapon();
    public static event  SwitchWwapon OnNewWepon;

    public event Action OnAction;
    public event Action Onexit;
    public event Action OnWeponChange;
    public WeponUiEvent uiwepon;
    public Weapon[] weaponList;
    public int Weapondirectory = 1;

    private void Start()
    {
        OnAction += WeaponAction;
        Onexit += WeaponexitAction;
        OnWeponChange += ChangeWepon;

    }

    public void EnterAttackTrigger()
    {
        OnAction?.Invoke();
    }
    public void LeaveAttackTrigger()
    {
        Onexit?.Invoke();
    }
    public void WeaponChangeTrigger()
    {
        OnWeponChange?.Invoke();
    }
    private void ChangeWepon()
    {
       

      
        Currentweapon = weaponList[Weapondirectory];
        Weapondirectory++;
        uiwepon.WeponchangeTrigger(Weapondirectory);
        if(Weapondirectory >= weaponList.Length)
        {
            Weapondirectory = 0;
        }
        
    }
    private void WeaponAction()
    {
        Currentweapon.Attack();
    }
    private void WeaponexitAction()
    {
        Currentweapon.ExitAttack();
    }




}
