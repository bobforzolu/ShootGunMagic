using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(menuName = "dialogus/ dialogue event/managers", fileName = "eventManager ")]
    public class DialogueEvent : ScriptableObject
    {
        public event Action<TextAsset,int> OnDialogueTrigger;
        public void DialogueTrigger(TextAsset Story,int id)
        {
            OnDialogueTrigger?.Invoke(Story,id);
        }

        public event Action<int> OnDialogueEndTrigger;
        public void DialogueEndTrigger(int id)
        {
            OnDialogueEndTrigger?.Invoke(id);
        }


    }
}
