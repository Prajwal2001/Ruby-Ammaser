using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost1Move : MonoBehaviour
{
    float dirX, movespeed = 2f;
    bool moveRight = true;
    void FixedUpdate()
    {
        if (transform.position.x > 175f)
            moveRight = false;
        if (transform.position.x < 166f)
            moveRight = true;
        if (moveRight)
            transform.position = new Vector2(transform.position.x + movespeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - movespeed * Time.deltaTime, transform.position.y);
    }
}
