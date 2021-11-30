using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractAction : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public Transform CaveHole;
    public Inventory inventory;
    public UI_Inventory uI_Inventory;
    public Item item;
    public TextBox textBox;
    public Transform SceneTransition;
    public bool end;
    public void ActionEvent()
    {
        switch (gameObject.name)
        {
            case "Hole":
                if (playerInventory.LadleState == true)
                {
                    gameObject.SetActive(false);
                    Instantiate(CaveHole, transform.position, Quaternion.identity);
                    SceneTransition.gameObject.SetActive(true);
                    //inventory.RemoveItem();
                }
                break;
            case "parmegano":
                if (playerInventory.ForkState == true)
                {
                    Debug.Log("end time");
                    gameObject.SetActive(false);
                    uI_Inventory.gameObject.SetActive(false);
                    end = true;
                    playerInventory.animator.SetTrigger("nothing");
                    playerInventory.ForkState = false;
                }
                //inventory.RemoveItem();
                break;
            default:
                break;
        }
    }
}
