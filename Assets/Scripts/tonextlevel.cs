using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
public class tonextlevel : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.tag == "door")
        {
            
            SceneManager.LoadScene("level 2 text scene");
        }
    }
}
