using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void StartGame()
    {
        if (gameObject.name == "Start")
        {
            SceneManager.LoadScene("Desert");
        }
    }
    public void EndGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }
}
