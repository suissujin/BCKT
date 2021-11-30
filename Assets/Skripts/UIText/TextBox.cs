using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBox : MonoBehaviour
{
    private Transform textBox;
    public InteractTypes interactTypes;
    public bool TextfieldActive;
    [SerializeField] public TextMeshProUGUI textMeshPro;
    private void Awake()
    {
        textBox = transform.Find("TextBox");
        TextfieldActive = false;
    }

    public void DisplayText()
    {
        textBox.gameObject.SetActive(true);
        TextfieldActive = true;
    }

    public void CloseText()
    {
        textBox.gameObject.SetActive(false);
    }
}
