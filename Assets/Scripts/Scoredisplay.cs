using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoredisplay : MonoBehaviour
{
    public static Scoredisplay instance;
    public TextMeshProUGUI text;
    int score;
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    public void ChangeScore(int rubyvalue)
    {
        score = rubyvalue;
        text.text = "X" + score.ToString();
    }
}
