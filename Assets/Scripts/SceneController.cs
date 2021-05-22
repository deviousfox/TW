using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class SceneController: MonoBehaviour
{
    //reload scene get index current scene and reload this
    private void ReloadScene()
    {
        Scene currentScene =  SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
    
    //subscribe on ReloadSceneEventHandler
    private void OnEnable()
    {
        UIListener.ReloadSceneEventHandler += ReloadScene;
    }
//unsubscribe on ReloadSceneEventHandler
    private void OnDisable()
    {
        UIListener.ReloadSceneEventHandler -= ReloadScene;
    }

   
}
