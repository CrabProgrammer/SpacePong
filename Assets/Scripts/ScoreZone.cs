using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreZone : MonoBehaviour
{
    // Start is called before the first frame update
    public CountdownTimer timer;
    public TMPro.TextMeshProUGUI score;
    public TMPro.TextMeshProUGUI winText;
    public string winner;

    private BallController ball;
    

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("ball").GetComponent<BallController>();
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
            winText.text = winner+" Win";
        }
    }
}
