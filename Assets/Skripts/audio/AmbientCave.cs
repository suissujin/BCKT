using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientCave : MonoBehaviour
{
    public AudioSource source;
    public AudioClip ambient2;
    void Start()
    {
        InvokeRepeating("PlayClip", 2f, 8f);
    }

    void PlayClip()
    {
        source.PlayOneShot(ambient2);
    }
}
