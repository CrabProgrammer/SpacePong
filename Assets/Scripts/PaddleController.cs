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
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 myPosition = rigidBody.position;
        myPosition.y = Mathf.Lerp(myPosition.y, mousePosition.y, 10);
        myPosition.y = Mathf.Clamp(myPosition.y,-3.7f,3.7f);
        rigidBody.position = myPosition;

    }
}
