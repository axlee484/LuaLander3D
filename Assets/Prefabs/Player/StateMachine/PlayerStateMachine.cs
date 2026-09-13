using PlayerStates.StateMachine.States;
using UnityEngine;


public class PlayerStateMachine : BaseStateMachine<PlayerStateId, PlayerContext>
{
    private PlayerContext CreateContext()
    {
        var player = GetComponent<Player>();
        return new PlayerContext(player);
    }
    protected override void Setup()
    {
        var context = CreateContext();
        var readyState = new Ready(PlayerStateId.Ready, context);
        var idleState = new Idle(PlayerStateId.Idle, context);
        var flyingState = new Flying(PlayerStateId.Flying, context);
        var landedState = new Landed(PlayerStateId.Landed, context);
        var deadState = new Dead(PlayerStateId.Dead, context);

        states.Add(PlayerStateId.Ready, readyState);
        states.Add(PlayerStateId.Idle, idleState);
        states.Add(PlayerStateId.Flying, flyingState);
        states.Add(PlayerStateId.Landed, landedState);
        states.Add(PlayerStateId.Dead, deadState);
    }
}

