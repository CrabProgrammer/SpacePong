using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreZone : MonoBehaviour
{
    // Start is called before the first frame update
    public CountdownTimer timer;
    public TextMeshProUGUI score;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI replayText;
    public Button replayButton;
    public Button exitButton;


    public string winner;

    private BallController ball;
    

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("ball").GetComponent<BallController>();
        winText.enabled = false;
        replayText.enabled = false;
        replayButton.enabled = false;
        exitButton.enabled = false;
        replayButton.GetComponentInChildren<TextMeshProUGUI>().enabled = false;
        exitButton.GetComponentInChildren<TextMeshProUGUI>().enabled = false;


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        score.text = (int.Parse(score.text) + 1).ToString();
        if (int.Parse(score.text) < 9)
            timer.NewCountdown();
        else
        {
            ball.GetComponent<SpriteRenderer>().enabled = false;
            ball.StopBall();
            winText.enabled = true;
            replayText.enabled = true;
            replayButton.enabled = true;
            exitButton.enabled = true;
            replayButton.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            exitButton.GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            winText.text = winner+" Win";
        }
    }
}
