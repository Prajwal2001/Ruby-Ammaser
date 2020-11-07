using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirY, movespeed = 3f;
    bool moveUp = true;
    void FixedUpdate()
    {
        if (transform.position.y > 3y)
                moveUp = false;
        if (transform.position.y < -4y)
                moveUp = true;
        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - movespeed * Time.deltaTime);
    }
}
