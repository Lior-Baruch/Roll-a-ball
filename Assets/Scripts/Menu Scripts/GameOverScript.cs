using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour
{
    public GameObject GameOverMenuUI;
    public GameObject Player;
    public GameObject Ground;

    private void FixedUpdate()
    {
        if(Player.transform.position.y < Ground.transform.position.y)
        {
            GameActions.Pause();
            GameOverMenuUI.SetActive(true);
        }
    }
    public void Exit()
    {
        GameActions.Quit();
    }

    // Update is called once per frame
    public void Restart()
    {
        GameActions.RestartScene();
        GameActions.Resume();
    }
}
