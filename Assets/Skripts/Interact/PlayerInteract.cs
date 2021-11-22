using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    public ForkEquiped fork;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            try
            {
                StartCoroutine(fork.ForkState());
            }
            catch (NullReferenceException)
            {
                Debug.Log("Its not working :(((");
            }
        }
    }
}
