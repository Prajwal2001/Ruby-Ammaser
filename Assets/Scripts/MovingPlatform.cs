using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    float dirY, movespeed = 3.5f;
    bool moveUp = true;
    void FixedUpdate()
    {
        if (transform.position.y > 4f)
                moveUp = false;
        if (transform.position.y < -3f)
                moveUp = true;
        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - movespeed * Time.deltaTime);
    }
}
