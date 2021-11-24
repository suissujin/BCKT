using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTypes : MonoBehaviour
{
    protected ForkMessage forkMessage;
    protected LadleMessage ladleMessage;
    public enum ObjectType
    {
        Hole,
        Succulent,
        Bones,
    }
    public void TypeCheck()
    {
        switch (gameObject.name.ToString())
        {
            case "Hole":
                InteractEvent(1);
                break;

            case "Succulent":
                InteractEvent(2);
                break;
            case "Bone":
                InteractEvent(3);
                break;
        }
    }

    public void InteractEvent(int index)
    {
        switch (index)
        {
            case 1:
                forkMessage.Fork(1);
                ladleMessage.Ladle(1);
                break;
            case 2:
                forkMessage.Fork(2);
                ladleMessage.Ladle(2);
                break;
            case 3:
                forkMessage.Fork(3);
                ladleMessage.Ladle(3);
                break;
        }
    }
}