using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{

    public class ProgressBarController : MonoBehaviour
    {
        public float progress;
        public float minProgress;
        public float maxProgress;
        private Slider ProgressBar;
        private void Start()
        {
            ProgressBar = GetComponent<Slider>();
        }
        void Update()
        {
            UpdateProgressBar();
            progress = Mathf.Clamp(progress, minProgress, maxProgress);
        }
        void UpdateProgressBar()
        {
            ProgressBar.value = progress;
        }
    }
}