using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fullscreenmanager : MonoBehaviour
{
    bool isopen = true;
    public Text screenstatus;

    void Start()
    {
        Screen.fullScreen = true;
        screenstatus.text = "Fullscreen: ON";
    }

    public void changesetting()
    {
        if(isopen == true)
        {
            isopen = false;
            screenstatus.text = "Fullscreen: OFF";
            Screen.fullScreen = false;
        }
        else
        {
            isopen = true;
            screenstatus.text = "Fullscreen: ON";
            Screen.fullScreen = true;
        }
    }
}
