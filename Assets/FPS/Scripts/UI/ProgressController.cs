using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{

    public class ProgressController : MonoBehaviour
    {
        public ProgressBarController ProgressBar;
        public float ProgressChange;
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                ProgressBar.progress += ProgressChange;
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                ProgressBar.progress -= ProgressChange;
            }
        }
    }
}