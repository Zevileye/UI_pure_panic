using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Unity.FPS.UI
{


    public class HeartScript : MonoBehaviour
    {
        // The amount of blood a heart contains
        public int TotalBlood = 1;

        // Current blood volume of the heart
        public int CurrentBlood = 0;

        private int preBlood = 0;

        private Transform process;

        private void Awake()
        {
            process = this.transform.Find("HeartMask/Process");
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (preBlood != CurrentBlood)
            {
                var height = process.gameObject.GetComponent<RectTransform>().sizeDelta.y;
                process.gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(0.0f, -(float)(TotalBlood - CurrentBlood) / TotalBlood * height);

                preBlood = CurrentBlood;
            }
        }
    }
}