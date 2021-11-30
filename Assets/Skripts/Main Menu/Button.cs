using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void OnClick()
    {
        if (gameObject.name == "Start")
        {
            SceneManager.LoadScene("Desert");
        }
        if (gameObject.name == "Exit")
        {
            Application.Quit();
        }
    }
}
