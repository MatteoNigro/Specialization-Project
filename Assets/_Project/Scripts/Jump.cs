using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float height;
    private PlayerInputActions playerInputActions;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();

        playerInputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        playerInputActions.Player.Jump.Enable();
        playerInputActions.Player.Jump.performed += Jumping;
    }


    private void OnDisable()
    {
        playerInputActions.Player.Jump.Disable();
    }

    public void Jumping(InputAction.CallbackContext context)
    {
        rigidbody.velocity = Vector2.up * height;
    }
}
