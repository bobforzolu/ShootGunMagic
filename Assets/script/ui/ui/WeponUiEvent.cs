using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Laurence
{
    [CreateAssetMenu(fileName = "ui Events ",menuName ="Events/ Ui/ Weponui")]
    public class WeponUiEvent : ScriptableObject
    {
        public event Action<int> OnWeaponChange;
        public void WeponchangeTrigger(int currentweapon)
        {
            OnWeaponChange?.Invoke(currentweapon);
        }
      
    }
}
