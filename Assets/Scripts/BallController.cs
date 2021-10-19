using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int thrust;
    AudioSource BallAudio;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        BallAudio = GetComponent<AudioSource>();

    }
    public void StopBall()
    {
        transform.position = Vector2.zero;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallAudio.Play();
    }
    public void ResetBall()
    {
        transform.position = Vector2.zero;
        rb.velocity = Vector2.zero;
        List<Vector2> directions = new List<Vector2>();
        directions.Add(new Vector2(-10, -10));
        directions.Add(new Vector2(-10, 10));
        directions.Add(new Vector2(10, -10));
        directions.Add(new Vector2(10, 10));
        int index = Random.Range(0, directions.Count);
        GetComponent<Rigidbody2D>().AddForce(directions[index] * Global.speed, ForceMode2D.Force);

    }
}
