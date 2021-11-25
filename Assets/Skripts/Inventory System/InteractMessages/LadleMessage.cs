using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadleMessage
{
    public string Ladle(int index)
    {
        switch (index)
        {
            case 1: return "Who would have thougt? A Ladle is as good as a shovel!";
            case 2: return "nothing left here";
            case 3: return "not good";
            default: return null;
        };
    }
}