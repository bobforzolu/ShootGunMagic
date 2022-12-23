using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Laurence
{
    [CreateAssetMenu(menuName =" Lootevent",fileName ="loot / loot events / drop event")]
    public class LootEvent : ScriptableObject
    {
        public event Action<Transform> OnDropLoot;
        public void DropLootTrigger( Transform pos)
        {
            OnDropLoot?.Invoke(pos);
        }
    }
}
