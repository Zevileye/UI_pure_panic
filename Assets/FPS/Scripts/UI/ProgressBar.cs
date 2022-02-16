using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{
    
    public class ProgressBar : MonoBehaviour
    {
        private Slider slider;

        public float FillSpeed = 0.5f;
        private float targetProgress = 0;

        // Start is called before the first frame update
        private void Awake()
        {
            slider = gameObject.GetComponent<Slider>();
        }

        private void Start()
        {
            IncrementPorgress(0.75f);
        }

        // Update is called once per frame
        void Update()
        {
            if (slider.value < targetProgress)
                slider.value += FillSpeed * Time.deltaTime;
        }

        public void IncrementPorgress(float newProgress)
        {
            targetProgress = slider.value + newProgress;
        }

    }

}