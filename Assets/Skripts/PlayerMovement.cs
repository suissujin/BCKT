using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public InteractAction interactAction;
    public TextBox textBox;
    public Animator animator;
    public Animator endAnimator;
    Vector2 movement;
    void Awake()
    {
        Cursor.visible = false;
    }
    #region WalkMovement (Update)
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (movement.x != 0)
        {
            movement.y = Input.GetAxisRaw("Vertical");
        }

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
            animator.SetTrigger("Walking");
            textBox.CloseText();
        }

        if (interactAction.end == true && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Return)))
        {
            endAnimator.SetTrigger("end");
            textBox.CloseText();
            movement.x = 0;
            movement.y = 0;
        }
    }
    #endregion
    void FixedUpdate()
    {
        #region (Physics)
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (movement.x != 0)
        {
            movement.y = 0;
        }

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
        }
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        #endregion
    }
}