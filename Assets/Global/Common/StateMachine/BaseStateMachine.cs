using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseStateMachine<TStateType, TContext> : MonoBehaviour 
where TStateType  : Enum
where TContext: class
{
    [SerializeField] private TStateType initialStateId;
    private IState<TStateType, TContext> currentState;
    private readonly Dictionary<TStateType, IState<TStateType, TContext>> states = new();

    public abstract void Setup();
    private void Awake()
    {
        Setup();
        foreach(var (stateId, state) in states)
        {
            state.ChangeState += OnChangeState;
        }
    }
    private void Start()
    {
        currentState = states[initialStateId];
        currentState.Enter();
    }

    private void Update()
    {
        currentState.Update();
    }

    private void FixedUpdate()
    {
        currentState.FixedUpdate();
    }

    private void OnChangeState(TStateType stateId)
    {
        currentState.Exit();
        currentState = states[stateId];
        currentState.Enter();
    }
}
