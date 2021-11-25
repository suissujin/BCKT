using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NothignMessage
{
    public string Nothing(int index)
    {
        switch (index)
        {
            case 1: return "The sand looks like its sinking...";
            case 2: return "Ouch!";
            case 3: return "Hello...";
            default: return null;
        };
    }
}