using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rubyscript : MonoBehaviour
{
    public int rubyval = 1;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("groundT"))
        {
            Scoredisplay.instance.ChangeScore(rubyval);
            Destroy(gameObject);
        }
    }
}
