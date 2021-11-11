using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onScreenToggle : MonoBehaviour
{

    public Sprite W;
    public Sprite A;
    public Sprite S;
    public Sprite D;
    
    private void OnBecameInvisible()
 {
     gameObject.SetActive(false);
 }

}
