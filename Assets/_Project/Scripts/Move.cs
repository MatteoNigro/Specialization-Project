using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    private Rigidbody2D rigidbody;
    [SerializeField] private float speed;
    PlayerInputActions playerInputActions;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Movement.Enable();
    }



    public void Update()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        rigidbody.velocity = new Vector2(inputVector.x * speed, 0);

    }

}
