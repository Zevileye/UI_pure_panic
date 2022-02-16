using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Unity.FPS.UI
{
    public class HealthSystemScript : MonoBehaviour
    {

        // The amount of blood a heart contains
        public int TotalBloodPerheart = 6;

        // Current blood volume
        public int CurrentBlood = 0;

        private int preBlood = 0;

        private int maxBloodVolum = 0;

        private HeartScript[] hearts;

        private void Awake()
        {
            hearts = this.GetComponentsInChildren<HeartScript>();
            foreach (var heart in hearts)
            {
                heart.TotalBlood = TotalBloodPerheart;
            }

            maxBloodVolum = TotalBloodPerheart * hearts.Length;
            CurrentBlood = maxBloodVolum;
            preBlood = maxBloodVolum;
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
                // deal with border issues
                int maxBloodVolum = TotalBloodPerheart * hearts.Length;
                CurrentBlood = Mathf.Max(CurrentBlood, 0);
                CurrentBlood = Mathf.Min(CurrentBlood, maxBloodVolum);

                // 
                for (int i = 0; i < hearts.Length; ++i)
                {
                    var halfIndex = CurrentBlood / TotalBloodPerheart;
                    if (i < halfIndex)
                    {
                        hearts[i].CurrentBlood = TotalBloodPerheart;
                    }
                    else if (i > halfIndex)
                    {
                        hearts[i].CurrentBlood = 0;
                    }
                    else
                    {
                        hearts[i].CurrentBlood = CurrentBlood % TotalBloodPerheart;
                    }
                }

                preBlood = CurrentBlood;
            }
        }
    }
}