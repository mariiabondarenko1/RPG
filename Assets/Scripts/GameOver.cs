﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
  public string sceneToLoad;

  public void GameRestart()
    { 
        //if (transform.gameObject.enabled)
        {
            SceneManager.LoadScene(sceneToLoad);

        }
    }
}
