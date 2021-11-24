using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUses
{
    public bool ForkInteractable;
    public bool LadleInteractable;
    protected InteractTrigger interactTrigger;
    protected PlayerInventory playerInventory;
    protected InteractTypes interactTypes;

    public void UseTypeCheck()
    {
        if (playerInventory.ForkState == true)
        {
            Debug.Log(interactTypes.TypeCheck(){
                interactTypes.InteractEvent(){ forkMessage.Fork()};
            }
        }
    }
}