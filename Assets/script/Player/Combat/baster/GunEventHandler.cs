using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;

namespace Laurence.script
{
    [CreateAssetMenu(fileName ="blasterEventHandler",menuName = "Events/blaster event Handler")]
    public class GunEventHandler : ScriptableObject
    {
        public event Action OnRecoveryAmmo;
        public void RecoveryHitTrigger()
        {
            OnRecoveryAmmo?.Invoke();
        }
        public event Action onAmmoSwithchLeft;
        public void AmmoSwitchTriggerLeft()
        {
            onAmmoSwithchLeft?.Invoke();
        }

        public event Action onAmmoSwithchRight;
        public void AmmoSwitchTriggerRight()
        {
            onAmmoSwithchRight?.Invoke();
        }

        public event Action OnShootTrigger;
        public void ShootTrigger()
        {
            OnShootTrigger?.Invoke();
        }

        public event Action OnHitTrigger;
        public void HitTrigger()
        {
            OnShootTrigger?.Invoke();
        }

        public event Action<int> OnAmmoUiUpdate;
        public void UiUpaadtetrigger(int index )
        {
            OnAmmoUiUpdate?.Invoke(index);
        }
    }
}
