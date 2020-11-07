using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public bool isGrounded = false;

    void FixedUpdate()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * speed;
    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded== true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 6f), ForceMode2D.Impulse);
        }
    }
}
