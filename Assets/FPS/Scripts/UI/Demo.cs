using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.UI
{

    public class Demo : MonoBehaviour
    {
        [SerializeField] Timer timer1;

        // Start is called before the first frame update
        private void Start()
        {
            timer1
                .SetDuration(60)
                .OnBegin (() => Debug.Log("Timer started"))
                .OnChange((remainingSeconds) => Debug.Log("Timer started:" + remainingSeconds))
                .OnEnd(() => Debug.Log("Timer started"))
                .OnPause(ispaused => Debug.Log("Timer Paused:" + ispaused))
                .Begin();
        }



        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKeyDown("tab"))
                timer1.SetPaused(timer1.IsPaused);
        }
    }
}