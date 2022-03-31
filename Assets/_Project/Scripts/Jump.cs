using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float height;
    PlayerInputActions playerInputActions;
    private InputAction jump;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        playerInputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        jump = playerInputActions.Player.Jump;
        jump.Enable();
        jump.performed += Jumping;
    }

    private void OnDisable()
    {
        jump.Disable();
    }

    public void Jumping(InputAction.CallbackContext context)
    {
        var jumpInputAmount = context.ReadValue<Vector2>();
        rigidbody.AddForce(jumpInputAmount * height, ForceMode2D.Impulse);
    }
}
