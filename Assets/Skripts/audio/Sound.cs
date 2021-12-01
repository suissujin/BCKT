using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip walkSand1;
    public AudioClip walkSand2;
    public AudioClip walkCave1;
    public AudioClip walkCave2;
    public AudioClip pickup;
    public AudioClip button;
    public AudioClip start;
    void Awake()
    {
        source.PlayOneShot(start);
    }
    void WalkSand1()
    {
        source.PlayOneShot(walkSand2);
    }
    void WalkSand2()
    {
        source.PlayOneShot(walkSand2);
    }
    void WalkCave1()
    {
        source.PlayOneShot(walkCave1);
    }
    void WalkCave2()
    {
        source.PlayOneShot(walkCave2);
    }
    public void Pickup()
    {
        source.PlayOneShot(pickup);
    }
    public void ButtonHover()
    {
        source.PlayOneShot(button);
    }
}
