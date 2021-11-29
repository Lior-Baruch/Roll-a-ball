using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class GameActions
{
    private static bool s_GameIsPaused = false;
    // Start is called before the first frame update
    public static void Pause()
    {
        Time.timeScale = 0.0f;
        s_GameIsPaused = true;
    }

    public static void Resume()
    {
        Time.timeScale = 1.0f;
        s_GameIsPaused = false;
    }

    public static void Quit()
    {
        if (Application.isEditor)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
        else
        {
            Application.Quit();
        }
    }

    public static void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public static bool GameIsPaused
    {
        get
        {
            return s_GameIsPaused;
        }
    }
}
