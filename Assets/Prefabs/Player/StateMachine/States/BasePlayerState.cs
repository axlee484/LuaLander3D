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

public readonly struct PlayerContext
{
    public readonly Player player;
    public PlayerContext(Player player)
    {
        this.player = player;
    }
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

    public virtual void Enter()
    {
        Debug.Log($"Entering {stateId}");
    }

    public virtual void Exit()
    {
        Debug.Log($"Exiting {stateId}");
    }

    public virtual void FixedUpdate(){}

    public virtual void Update(){}

    public virtual (float forwardInput, float rotationInput) GetInput()
    {
        var forward = GameInput.InputActions.Player.Thrust.ReadValue<float>();
        var rotation = GameInput.InputActions.Player.Tilt.ReadValue<float>();
        return (forward, rotation);
    }
    public virtual void OnCollisionEnter(Collision collision){}
    public virtual void OnCollisionStay(Collision collision){}
    public virtual void OnCollisionExit(Collision collision){}
    public virtual void OnTriggerEnter(Collider other){}
    public virtual void OnTriggerStay(Collider other){}
    public virtual void OnTriggerExit(Collider other){}
}
