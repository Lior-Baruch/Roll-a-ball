using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PausePanelScript : MonoBehaviour
{
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!GameActions.GameIsPaused)
            {
                Pause();
            }
            else
            {
                Resume();
            }
        }
    }

    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        GameActions.Pause();
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        GameActions.Resume();
    }

    public void Quit()
    {
        GameActions.Quit();
    }




}
