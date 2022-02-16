using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{
    public class PaintBarController : MonoBehaviour
    {
        public PaintController paintController;
        private Image PaintBar;
        private void Start()
        {
            PaintBar = GetComponent<Image>();
        }
        void Update()
        {
            PaintBar.fillAmount = paintController.UpdatePaintBar();
        }
    }
}