using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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
            SFXscript.PlaySound("jumpsound");
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 7f), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("CorrectRuby"))
        {
            Destroy(other.gameObject);
        }
    }
}
