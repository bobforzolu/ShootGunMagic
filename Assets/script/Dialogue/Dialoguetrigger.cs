using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Dialoguetrigger : MonoBehaviour
    {
        public DialogueObject textjason;
        public DialogueEvent dialogue;
        [SerializeField]private int id;
        private void Start()
        {
            dialogue.OnDialogueEndTrigger += CloseEvent;
        }

        private void Awake()
        {
            
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.CompareTag("Player"))
                dialogue.DialogueTrigger(textjason.eventJason,id);
        }
        private void OnDisable()
        {
            dialogue.OnDialogueEndTrigger -= CloseEvent;

        }
        private void CloseEvent(int id)
        {
            if(id == this.id)
                gameObject.SetActive(false);
        }
    }
}
