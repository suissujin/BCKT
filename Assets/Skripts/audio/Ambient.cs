using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ambient : MonoBehaviour
{
    public AudioSource source;
    public AudioClip ambient1;
    void Start()
    {
        InvokeRepeating("PlayClip", 5f, 20f);
    }

    void PlayClip()
    {
        source.PlayOneShot(ambient1);
    }
}
