using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class togamescene1 : MonoBehaviour
{
    public void tonextlevel()
    {
        SceneManager.LoadScene("GameScene 1");
    }
}
