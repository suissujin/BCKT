using UnityEngine;



public class InteractTypes : MonoBehaviour
{
    public PlayerInventory playerInventory;
    public TextBox textBox;
    public ForkMessage forkMessage;
    public LadleMessage ladleMessage;
    public NothignMessage nothignMessage;
    protected Inventory inventory;
    #region InteractEvent
    public void InteractEvent(string item)
    {
        switch (gameObject.name)
        {
            case "Hole":
                if (item == "Fork")
                {
                    textBox.textMeshPro.text = forkMessage.Fork(1);
                }
                else if (item == "Ladle")
                {

                    textBox.textMeshPro.text = ladleMessage.Ladle(1);
                }
                else if (item == "Nothing")
                {

                    textBox.textMeshPro.text = nothignMessage.Nothing(1);
                }
                else
                {
                    Debug.Log("whoopsie");
                }
                break;
            case "Succulent":
                if (item == "Fork")
                {

                    textBox.textMeshPro.text = forkMessage.Fork(2);
                }
                else if (item == "Ladle")
                {

                    textBox.textMeshPro.text = ladleMessage.Ladle(2);
                }
                else if (item == "Nothing")
                {

                    textBox.textMeshPro.text = nothignMessage.Nothing(2);
                }
                else
                {
                    Debug.Log("whoopsie");
                }
                break;
            case "Bones":
                if (item == "Fork")
                {

                    textBox.textMeshPro.text = forkMessage.Fork(3);
                }
                else if (item == "Ladle")
                {

                    textBox.textMeshPro.text = ladleMessage.Ladle(3);
                }
                else if (item == "Nothing")
                {

                    textBox.textMeshPro.text = nothignMessage.Nothing(3);
                }
                else
                {
                    Debug.Log("whoopsie");
                }
                break;
            case "parmegano":
                if (item == "Fork")
                {
                    textBox.textMeshPro.text = forkMessage.Fork(4);
                }
                else if (item == "Nothing")
                {

                    textBox.textMeshPro.text = nothignMessage.Nothing(3);
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
    #endregion
    #region  TypeCheck
    public void UseTypeCheck()
    {
        if (playerInventory.ForkState == true)
        {
            InteractEvent("Fork");
        }
        else if (playerInventory.LadleState == true)
        {
            InteractEvent("Ladle");
        }
        else
        {
            InteractEvent("Nothing");
        }
    }
    #endregion
}