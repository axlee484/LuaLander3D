using System;
using UnityEngine;

public enum PlayerStateId
{
    Ready,
    Idle,
    Flying,
    Landed,
    Dead
}

public class PlayerContext
{
    
}
public abstract class BasePlayerState : IState<PlayerStateId, PlayerContext>
{
    public event Action<PlayerStateId> ChangeState;
    private readonly PlayerStateId stateId;
    public PlayerStateId StateId => stateId;
    public void InvokeChangeState(PlayerStateId nextStateId)
    {
        ChangeState?.Invoke(nextStateId);
    }
    private readonly PlayerContext context;
    public PlayerContext Context => context;
    public BasePlayerState(PlayerStateId stateId, PlayerContext context)
    {
        this.stateId = stateId;
        this.context = context;
    }

    public virtual void Enter(){}

    public virtual void Exit(){}

    public virtual void FixedUpdate(){}

    public virtual void Update(){}
}
