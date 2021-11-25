using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTypes : MonoBehaviour
{
    protected ForkMessage forkMessage;
    protected LadleMessage ladleMessage;
    protected NothignMessage nothignMessage;
    protected Inventory inventory;
    protected PlayerInventory playerInventory;
    // public void Awake()
    // {
    //     UseTypeCheck();
    // }
    public void InteractEvent(string item)
    {
        switch (gameObject.name)
        {
            case "Hole":
                if (item == "Fork")
                {

                    Debug.Log(forkMessage.Fork(1));
                }
                else if (item == "Ladle")
                {

                    Debug.Log(ladleMessage.Ladle(1));
                }
                else if (item == "Nothing")
                {

                    Debug.Log(nothignMessage.Nothing(1));
                }
                else
                {
                    Debug.Log("whoopsie");
                }
                break;
            case "Succulent":
                if (item == "Fork")
                {

                    Debug.Log(forkMessage.Fork(2));
                }
                else if (item == "Ladle")
                {

                    Debug.Log(ladleMessage.Ladle(2));
                }
                else if (item == "Nothing")
                {

                    Debug.Log(nothignMessage.Nothing(2));
                }
                else
                {
                    Debug.Log("whoopsie");
                }
                break;
            case "Bones":
                if (item == "Fork")
                {

                    Debug.Log(forkMessage.Fork(3));
                }
                else if (item == "Ladle")
                {

                    Debug.Log(ladleMessage.Ladle(3));
                }
                else if (item == "Nothing")
                {

                    Debug.Log(nothignMessage.Nothing(3));
                }
                else
                {
                    Debug.Log("whoopsie");
                }
                break;
            default:
                Debug.Log("whoopsie");
                break;
        }
    }

    // public void UseTypeCheck()
    // {
    //     if (playerInventory.ForkState == true)
    //     {
    //         Debug.Log("Lets go");
    //         InteractEvent("Fork");
    //     }
    //     if (playerInventory.LadleState == true)
    //     {
    //         InteractEvent("Ladle");
    //     }
    // }
}