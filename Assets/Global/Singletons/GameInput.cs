using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : MonoBehaviour
{
    public static GameInput Instance;
    public static InputActions InputActions;
    private void Awake()
    {
        Instance = this;
        InputActions = new InputActions();
        InputActions.Enable();
    }
}
