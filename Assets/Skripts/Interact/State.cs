using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected InteractTypes interactTypes;
    public virtual IEnumerator Start()
    {
        yield break;
    }
    public virtual IEnumerator ForkState()
    {
        yield break;
    }

    public virtual IEnumerator LadleState()
    {
        yield break;
    }
}