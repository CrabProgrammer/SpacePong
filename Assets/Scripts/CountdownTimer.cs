using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;
    public TextMeshProUGUI countdownText;
    private BallController ball;
    // Start is called before the first frame update
    void Start()
    {
        countdownText = GetComponent<TextMeshProUGUI>();
        ball = GameObject.FindGameObjectWithTag("ball").GetComponent<BallController>();
        NewCountdown();
    }
    public void NewCountdown()
    {
        ball.GetComponent<SpriteRenderer>().enabled=false;
        ball.StopBall();
        currentTime = startingTime;
        countdownText.enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime > 0)
        {
            countdownText.text = currentTime.ToString("0");
        }
        else if (currentTime <= 0 && currentTime >= -2)
        {
            countdownText.text = "Go";
            if (currentTime <= -1)
            {
                currentTime = -3;
                ball.GetComponent<SpriteRenderer>().enabled = true;
                ball.ResetBall();
                countdownText.enabled = false;
            }
        }
        

    }
}
