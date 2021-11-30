using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]
public class SceneTransition : MonoBehaviour
{
    public bool TransitionReady;
    public void SwitchScene()
    {
        SceneManager.LoadScene("Cave");
    }
    #region Trigger
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            TransitionReady = true;
        }
    }
    public void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            TransitionReady = true;
        }
    }
    public void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            TransitionReady = false;
        }
    }
    #endregion
}
