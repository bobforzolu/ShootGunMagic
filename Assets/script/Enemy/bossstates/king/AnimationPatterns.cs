using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class AnimationPatterns : MonoBehaviour
    {
        private string[] idleroutes = new string[2];
        private string[] walkStrings = new string[2];
        private string[] teleportStrings = new string[3];
        private string[] smashStrings = new string[2];
        private  string idle = "idle";
        private  string attak1 = "attack1";
        private  string attack2 = "attack2";
        private  string teleport = "teleport";
        private  string slam = "slam";
        private  string walk = "walk";

        private string IdlePreviousepattern;
        private string walkPreviousepattern;
        private string teleportPreviousepattern1 = "", teleportPreviousepattern2 = "";



        private void Start()
        {
            IdlePreviousepattern = "";
            walkPreviousepattern = "";

            idleroutes[0] = walk;
            idleroutes[1] = teleport;

            walkStrings[0] = attak1;
            walkStrings[1] = teleport;

            teleportStrings[0] = attak1;
            teleportStrings[1] = slam;
            teleportStrings[2] = idle;


            smashStrings[0] = idle;
            smashStrings[0] = attak1;



        }

        public string IdleRoulet()
        {
            if (IdlePreviousepattern.Equals(walk))
            {
                IdlePreviousepattern = teleport;
                return teleport;
            }
            else if (IdlePreviousepattern.Equals(teleport))
            {
                IdlePreviousepattern = walk;

                return walk;
            }
            else
            {
                int index = Random.Range(0, idleroutes.Length);
                IdlePreviousepattern = idleroutes[index];
                return idleroutes[index];
            }
        }

        public string WalkRoulet()
        {
            if (walkPreviousepattern.Equals(attak1))
            {
                walkPreviousepattern = teleport;
                return teleport;
            }
            else if (walkPreviousepattern.Equals(teleport))
            {
                walkPreviousepattern = attak1;

                return attak1;
            }
            else
            {
                int index = Random.Range(0, idleroutes.Length );
                walkPreviousepattern = walkStrings[index];
                return walkStrings[index];
            }
        }
        public string teleportRoulet()
        {
          
            int index = Random.Range(0, idleroutes.Length );
            teleportPreviousepattern1 = walkStrings[index];
            return teleportStrings[index];
            

        }
        public void SmashRoulet()
        {

        }

        
    }
}
