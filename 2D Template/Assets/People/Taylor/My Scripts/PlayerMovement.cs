using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    // Use the new Input System's event-based architecture.
    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Use FixedUpdate for physics calculations.
        // Multiply the normalized input vector by the speed to maintain consistent speed.
        rb.linearVelocity = moveInput.normalized * speed;
    }
}
