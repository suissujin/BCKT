using UnityEngine;

public class CameraMovement2 : MonoBehaviour
{
    public Transform thing;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (thing.transform.position.x == 0)
        {
            thing.transform.position = new Vector3(-18, 0, -10);
        }
        else if (thing.transform.position.x == -18)
        {
            thing.transform.position = new Vector3(0, 0, -10);
        }
    }
}

