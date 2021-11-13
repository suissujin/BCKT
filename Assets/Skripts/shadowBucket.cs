using UnityEngine;

public class ShadowBucket : MonoBehaviour
{
    [SerializeField] private Animator sanimator;
    private PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = new PlayerMovement();
    }
    void Update()
    {
        sanimator.SetFloat("Horizontal", Input.GetAxisRaw("Horizontal"));
        sanimator.SetFloat("Vertical", Input.GetAxisRaw("Vertical"));

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            sanimator.SetFloat("Speed", 3.75F);
            sanimator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            sanimator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
        }
        else
        {
            sanimator.SetFloat("Speed", 0);
        }
    }
    public void ShadowAni()
    {
        sanimator.SetTrigger("pickup");
    }
}

