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
    private void FixedUpdate()
    {
        var aheadInput = GameInput.InputActions.Player.Thrust.ReadValue<float>();
        var rotateInput = GameInput.InputActions.Player.Tilt.ReadValue<float>();
        print(rotateInput);
        movement.Move(Math.Sign(aheadInput) * Vector3.up, true);
        movement.Rotate(-Math.Sign(rotateInput)*Vector3.forward);
    }
}
