using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIListener : MonoBehaviour
{
    public delegate void  ReloadScene();
    public static event ReloadScene ReloadSceneEventHandler;
    
    public  delegate  void ChangeMoveSpeed(float speed);
    public static event ChangeMoveSpeed ChangeMoveSpeedEventHandler;

    public void SendReload()// send reload event
    {
        print("sendReload");
        ReloadSceneEventHandler?.Invoke();
    }

    public void SendChangeSpeed(Slider slider)// change player speed with event
    {
        ChangeMoveSpeedEventHandler?.Invoke(slider.value);
    }
}
