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
}
