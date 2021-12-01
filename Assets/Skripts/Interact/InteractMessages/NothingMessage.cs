using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class NothignMessage
{
    public string Nothing(int index)
    {
        switch (index)
        {
            case 1: return "The sand looks like its sinking...";
            case 2: return "Ouch!";
            case 3: return "The cheese is calling me...";
            default: return null;
        };
    }
}