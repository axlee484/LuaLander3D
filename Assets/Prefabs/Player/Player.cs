using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private RigidBodyMovement movement;
    private void Awake()
    {
        movement = GetComponent<RigidBodyMovement>();
    }
    public void DisableInput()
    {
        GameInput.InputActions.Player.Disable();
    }
    public void EnableInput()
    {
        GameInput.InputActions.Player.Enable();
    }
}
