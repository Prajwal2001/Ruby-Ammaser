using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour
{
    float dirY, movespeed = 2f;
    bool moveUp = true;
    void FixedUpdate()
    {
        if (transform.position.y > 4f)
            moveUp = false;
        if (transform.position.y < -0.1f)
            moveUp = true;
        if (moveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + movespeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - movespeed * Time.deltaTime);
    }
}