using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isGrounded = false;

    void FixedUpdate()
    {
        Jump();
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded== true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 6f), ForceMode2D.Impulse);
        }
    }
}
