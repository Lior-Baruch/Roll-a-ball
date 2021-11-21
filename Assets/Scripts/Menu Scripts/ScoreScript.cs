using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public GameObject Player;
    public Text ScoreText;
    public Text WinText;
    public int ScoreToWin;
    // Start is called before the first frame update
    void Start()
    {
        SetScoreText();
        WinText.text = "";
        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        SetScoreText();
        if (PlayerScore() >= ScoreToWin)
        {
            WinText.text = "You WIN!\n we will update the game with more levels soon :D ";
        }
    }

    private void SetScoreText()
    {
        ScoreText.text = "Score: " + PlayerScore().ToString();
    }

    private int PlayerScore()
    {
        return Player.GetComponent<PlayerController>().m_Score;
    }
}
