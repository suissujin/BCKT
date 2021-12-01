using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator animator;
    public Transform black;
    public void Awake()
    {
        animator.Play("base");
    }
    public void Start()
    {
        black.gameObject.SetActive(false);
    }

    public void LoadLastScene()
    {
        SceneManager.LoadScene("Endscreen");
    }
}
