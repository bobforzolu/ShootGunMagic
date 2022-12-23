using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    [CreateAssetMenu(menuName = "Events / player Input / input", fileName = "input")]
    public class PlayerInputEvent : ScriptableObject
    {
        public bool GetInput = true;
        public bool DialogueButton;
        

    }
}
