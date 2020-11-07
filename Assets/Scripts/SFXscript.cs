using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXscript : MonoBehaviour
{
    public static AudioClip cactusTouch, ironPlat, spiderTouch, jumpSound, playerDeath;
    static AudioSource audioSrc;
    void Start()
    {
        cactusTouch = Resources.Load<AudioClip>("cactussound");
        ironPlat = Resources.Load<AudioClip>("ironplat");
        spiderTouch = Resources.Load<AudioClip>("spidersound");
        jumpSound = Resources.Load<AudioClip>("jumpsound");
        playerDeath = Resources.Load<AudioClip>("playerdeath");

        audioSrc = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch(clip)
        {
            case "cactussound":
                audioSrc.PlayOneShot(cactusTouch);
                break;
            case "ironplat":
                audioSrc.PlayOneShot(ironPlat);
                break;
            case "spidersound":
                audioSrc.PlayOneShot(spiderTouch);
                break;
            case "jumpsound":
                audioSrc.PlayOneShot(jumpSound);
                break;
            case "playerdeath":
                audioSrc.PlayOneShot(playerDeath);
                break;
        }
    }
}
