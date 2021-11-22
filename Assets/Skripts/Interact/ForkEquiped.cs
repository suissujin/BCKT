using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForkEquiped : State
{
    public State state;
    public override IEnumerator ForkState()
    {
        Debug.Log("ForkState true");
        yield break;
    }
}
