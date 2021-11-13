using UnityEngine;

public class ShadowBucket : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] private Animator sanimator;
    private PlayerInventory playerInventory;
    private PlayerMovement playerMovement;
    void Start()
    {
        playerInventory = new PlayerInventory();
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

        if (playerInventory.inRange = true && Input.GetKeyDown(KeyCode.F))
        {
            sanimator.SetTrigger("pickup");
        }
    }
}
