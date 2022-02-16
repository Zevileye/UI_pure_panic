using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.UI
{
    public class InputScript : MonoBehaviour
    {
        public GameObject HealthObject;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                HealthObject.GetComponent<HealthSystemScript>().CurrentBlood -= 1;
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                HealthObject.GetComponent<HealthSystemScript>().CurrentBlood += 1;
            }

        }
    }
}