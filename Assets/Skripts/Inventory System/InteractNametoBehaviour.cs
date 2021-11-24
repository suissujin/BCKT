using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractNametoBehaviour : MonoBehaviour
{
    protected InteractTypes interacTypes;
    public void TypeSet()
    {
        switch (gameObject.name.ToString())
        {
            case "Hole":
                interacTypes.objectList = 0;
                break;

            case "Succulent":
                interacTypes.objectList = 1;
                break;
            case "Bone":
                interacTypes.objectList = 2;
                break;
        }
    }
