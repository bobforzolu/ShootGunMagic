using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace Laurence
{
    public class activatetimline : MonoBehaviour
    {
        public PlayableDirector eventanim;
        public GameObject StoryEvent3;
        public GameObject samuri;
        public Animator enemyanim;

        public void eneableEvent() 
        {
            eventanim.enabled= false;
            enemyanim.enabled= false;
            samuri.SetActive(true);
            StoryEvent3.SetActive(true);
            gameObject.SetActive(false);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            eventanim.enabled= true;
        }
      

    }
}
