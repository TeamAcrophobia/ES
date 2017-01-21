using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApplication : MonoBehaviour {

    public void QuitApp()
    {
#if UNITY_EDITOR
        // set the PlayMode to stop
#else
         Application.Quit();
#endif
    }
}
