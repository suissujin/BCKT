using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractTrigger : MonoBehaviour
{
    public bool useable;
    protected PlayerInventory playerInventory;
    protected InteractTypes interactTypes;

    public void start()
    {
        useable = false;
    }

    public void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Return)) && useable == true)
            if (playerInventory.ForkState == true)
            {
                Debug.Log("Lets go");
                interactTypes.InteractEvent("Fork");
            }
            else if (playerInventory.LadleState == true)
            {
                interactTypes.InteractEvent("Ladle");
            }
            else
            {
                interactTypes.InteractEvent("Nothing");
            }
    }
    #region Trigger
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            useable = true;
        Debug.Log("Item Useable");
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            useable = false;
        // Debug.Log("Item not Useable");
    }
    #endregion
}