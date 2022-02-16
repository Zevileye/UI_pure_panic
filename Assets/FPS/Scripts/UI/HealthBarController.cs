using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{

    public class HealthBarController : MonoBehaviour
    {

        public HealthController HealthController;
        private Image HealthBar;
        private void Start()
        {
            HealthBar = GetComponent<Image>();
        }
        void Update()
        {
            HealthBar.fillAmount = HealthController.UpdateHealthBar();
        }


    }
}