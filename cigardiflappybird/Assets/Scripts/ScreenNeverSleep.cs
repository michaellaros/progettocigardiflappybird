using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenNeverSleep : MonoBehaviour
{
    
        void Start()
        {
            // Disable screen dimming
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

    void OnApplicationPause(bool pause)
    {
        if(!pause)
        {
            // Disable screen dimming
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }
    }
    
}
