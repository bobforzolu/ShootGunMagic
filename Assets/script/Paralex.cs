using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Laurence
{
    public class Paralex : MonoBehaviour
    {
        public Transform[] backgrounds = new Transform[1];         // Array of all the backgrounds to be parallaxed.
        private float[] parallaxScales;         // Proportion of the camera's movement to move the backgrounds by.
        public float smoothing = 1f;            // How smooth the parallax effect will be.

        private Transform cam;                  // Reference to the main camera's transform.
        private Vector3 previousCamPos;         // The position of the camera in the previous frame.

        // Called before Start().
        void Awake()
        {
            // Set up the reference shortcut.
            backgrounds[0] = gameObject.transform;
            cam = Camera.main.transform;
        }

        // Use this for initialization
        void Start()
        {
            // The previous frame had the current frame's camera position.
            previousCamPos = cam.position;

            // Assigning corresponding parallaxScales.
            parallaxScales = new float[backgrounds.Length];
            for (int i = 0; i < backgrounds.Length; i++)
            {
                parallaxScales[i] = backgrounds[i].position.z * -1;
            }
        }

        // Update is called once per frame
        void Update()
        {
            // For each background.
            for (int i = 0; i < backgrounds.Length; i++)
            {
                // The parallax is the opposite of the camera movement because the previous frame multiplied by the scale.
                float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

                // Set a target x position which is the current position plus the parallax.
                float backgroundTargetPosX = backgrounds[i].position.x + parallax;

                // Create a target position which is the background's current position with it's target x position.
                Vector3 backgroundTargetPos = new Vector3(backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

                // Lerp the background's position between itself and it's target position.
                backgrounds[i].position = Vector3.Lerp(backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);
            }

            // Set the previousCamPos to the camera's position at the end of the frame.
            previousCamPos = cam.position;
        }
    }
}


