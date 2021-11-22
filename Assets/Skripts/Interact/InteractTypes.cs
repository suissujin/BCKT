using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTypes : State
{
    public bool Fork;
    public enum InteractType
    {
        ForkInteract,
        LadleInteract,
    }
}
