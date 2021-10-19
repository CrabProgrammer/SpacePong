using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    private void Movement()
    {
        foreach(Touch touch in Input.touches)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Vector2 myPosition = rigidBody.position;
            if (Mathf.Abs(touchPosition.x - myPosition.x) <= 5)
            {
                myPosition.y = Mathf.Lerp(myPosition.y, touchPosition.y, 10);
                myPosition.y = Mathf.Clamp(myPosition.y, -3.7f, 3.7f);
                rigidBody.position = myPosition;
            }
        }


    }
}
