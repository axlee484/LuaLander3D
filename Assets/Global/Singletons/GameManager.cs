using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] private int defaultLevel = 1;
    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        Instance = this;
    }

    private void Start()
    {
        EventManager.Instance.GameStartEvent += OnGameStart;
    }

    private void OnGameStart()
    {
        LevelManager.Instance.LoadLevel(defaultLevel);
    }

    private void Update()
    {
        if(Keyboard.current.spaceKey.isPressed) LevelManager.Instance.LoadNextLevel();
    }

    
}
