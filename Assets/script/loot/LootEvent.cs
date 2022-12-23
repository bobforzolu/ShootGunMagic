using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace Laurence
{
    [CreateAssetMenu(menuName =" Lootevent",fileName ="loot / loot events / drop event")]
    public class LootEvent : ScriptableObject
    {
        public event Action<Vector2> OnDropLoot;
        public void DropLootTrigger( Vector2 pos)
        {
            OnDropLoot?.Invoke(pos);
        }
    }
}
