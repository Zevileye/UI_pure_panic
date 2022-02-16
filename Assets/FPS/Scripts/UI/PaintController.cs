using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Unity.FPS.UI
{
    public class PaintController : MonoBehaviour
    {
        public float maxPaint = 100;
        public float Paint;
        public float PaintChange;
        void Start()
        {
            // Paint=maxPaint;
        }
        void Update()
        {
            if (Input.GetKeyDown("o"))
            {
                Paint += PaintChange;
            }
            if (Input.GetKeyDown("k"))
            {
                Paint -= PaintChange;
            }
            Paint = Mathf.Clamp(Paint, 0, maxPaint);
        }
        public float UpdatePaintBar()
        {
            return (float)Paint / (float)maxPaint;
        }
    }
}