using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Laurence
{
    public class DialogueManager : MonoBehaviour
    {
        [Header("dialogue ui")]
        [SerializeField] private GameObject DialoguePanel;
        [SerializeField] private TextMeshProUGUI Dialoguetext;
        [SerializeField] private GameObject Playerui;

        private int EventId;



        private Story currentstory;
        private bool dialoguePlaying;
        public PlayerInputEvent reaciveInput;
        public DialogueEvent dialogueEvent;
        private PlayerInputReaciver inputReaciver;

        void Start()
        {
            inputReaciver = FindObjectOfType<PlayerInputReaciver>();
            dialogueEvent.OnDialogueTrigger += Enterdialogue;
            DialoguePanel.SetActive(false);
            dialoguePlaying = false;
        }
        private void OnDestroy()
        {
            dialogueEvent.OnDialogueTrigger -= Enterdialogue;

        }

        // Update is called once per frame
        void Update()
        {
            if (!dialoguePlaying)
                return;

            if (inputReaciver.JumpInput)
            {
                inputReaciver.Jump_Is_Pressed();
                ContinueStory();
            }
        }
        public void Enterdialogue(TextAsset inkjason, int id)
        {
            reaciveInput.GetInput = false;
            Playerui.SetActive(false);
            EventId = id;
            currentstory = new Story(inkjason.text);
            DialoguePanel.SetActive(true);
            dialoguePlaying = true;
            ContinueStory();
             
        }
        private void Exitdialogue()
        {
            reaciveInput.GetInput = true;
            Playerui.SetActive(true);
            DialoguePanel.SetActive(false);
            dialoguePlaying = false;
            Dialoguetext.text = "";
            dialogueEvent.DialogueEndTrigger(EventId);
        }
        private void ContinueStory()
        {
            if (currentstory.canContinue)
                        {
                            Dialoguetext.text = currentstory.Continue();
                        }
                        else
                        {
                            Exitdialogue();
                        }
        }
    }
}
