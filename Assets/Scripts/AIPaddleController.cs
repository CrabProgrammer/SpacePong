using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;
    Vector3 move = Vector3.zero;
    public float speed = 20.0f;
    public BallController ball;

    void Update()
    {
        float d = ball.GetComponent<Rigidbody2D>().transform.position.y - transform.position.y;
        if (d > 0)
        {
            move.y = speed * Mathf.Min(d, 1.0f);
        }
        if (d < 0)
        {
            move.y = -(speed * Mathf.Min(-d, 1.0f));
        }
        transform.position += move * Time.deltaTime;
    }
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();

    }


}
