using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTransition_Player : MonoBehaviour
{
    public TextBox textBox;
    public SceneTransition sceneTransition;
    public bool SceneTransitionReady;

    void Update()
    {
        if (sceneTransition.TransitionReady == true && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.F)))
        {
            textBox.DisplayText();
            textBox.textMeshPro.text = "Jump into the hole? Y/N";
            SceneTransitionReady = true;
        }

        if (SceneTransitionReady == true && Input.GetKeyDown(KeyCode.Y))
        {
            sceneTransition.SwitchScene();
        }
        else if (SceneTransitionReady == true && Input.GetKeyDown(KeyCode.N))
        {
            textBox.CloseText();
        }
    }
}
