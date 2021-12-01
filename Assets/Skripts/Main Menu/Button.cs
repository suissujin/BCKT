using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public Transform credits;
    public void StartGame()
    {
        SceneManager.LoadScene("Desert");
    }
    public void EndGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }
    public void Credits()
    {
        credits.gameObject.SetActive(true);
    }
    public void Close()
    {
        credits.gameObject.SetActive(false);
    }
}
