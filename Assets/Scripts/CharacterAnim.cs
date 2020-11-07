using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>;
    }

    void update()
    {
        if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(Keycode.RightArrow))
        {
            anim.SetBool("isWalking", true);
            else
                anim.SetBool("isWalking", false);
        }
    }
}
