using System;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;
    public event Action GameStartEvent;
    public void InvokeGameStartEvent()
    {
        GameStartEvent.Invoke();
    }
    private void Awake()
    {
        if(Instance != null) Destroy(gameObject);
        Instance = this;
    }
    public event Action LoadNextLevel;
    public void InvokeLoadNextLevel()
    {
        LoadNextLevel.Invoke();
    }
}