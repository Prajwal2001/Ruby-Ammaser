using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animControl : MonoBehaviour
{
    GameObject player;
    Rigidbody2D rb;
    SpriteRenderer sr;

    public float speed = 5f;
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        sr = this.GetComponent<SpriteRenderer>();
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * (Time.deltaTime * speed));
            anim.SetBool("isWalking", false);
            sr.flipX = true;
        }
        else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * (Time.deltaTime * speed));
            anim.SetBool("isWalking", true);
            sr.flipX = false;
        }

        else
            anim.SetBool("isWalking", false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("CorrectRuby"))
        {
            Destroy(other.gameObject);
        }
    }
}
