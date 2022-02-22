using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Song : MonoBehaviour
{

    public static Song song;
    public AudioSource audioSource;

    public AudioClip[] clip;

    float volume = 1f;

    public void Start()
    {
        song = this;
    }
    public void Miss()
    {
        audioSource.PlayOneShot(clip[0], 0.3f);
    }

    public void Good()
    {
        audioSource.PlayOneShot(clip[1], volume);
    }
    public void Bad()
    {
        audioSource.PlayOneShot(clip[2], volume);
    }


}
