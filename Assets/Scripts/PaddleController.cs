using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    Rigidbody2D paddleRigidbody;
    public float moveSpeed;

    private void Awake()
    {
        paddleRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        TouchMove();
    }

    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(touchPos.x < 0)
            {
                paddleRigidbody.velocity = Vector2.left * moveSpeed;
            }
            else
            {
                paddleRigidbody.velocity = Vector2.right * moveSpeed;
            }
        }
        else
        {
            paddleRigidbody.velocity = Vector2.zero;
        }

    }
}
