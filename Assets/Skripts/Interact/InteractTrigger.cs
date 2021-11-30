using UnityEngine;

public class InteractTrigger : MonoBehaviour
{
    public bool useable;
    public TextBox textBox;
    public void Start()
    {
        useable = false;
    }
    #region  Update
    public void Update()
    {
        if ((Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Return)) && useable == true)
        {
            GetComponent<InteractTypes>().UseTypeCheck();
            GetComponent<InteractAction>().ActionEvent();
            textBox.DisplayText();
            useable = false;
        }
        else if (textBox.TextfieldActive == true && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Return)))
        {
            textBox.CloseText();
        }

    }
    #endregion
    #region Trigger
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            useable = true;
        // Debug.Log("Item Useable");
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
            useable = false;
        // Debug.Log("Item not Useable");
    }
    #endregion
}