using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ForkMessage
{
    public string Fork(int index)
    {
        switch (index)
        {
            case 1: return "that wont do anything";
            case 2: return "maybe not";
            case 3: return "almost";
            default: return null;
        }
    }
}