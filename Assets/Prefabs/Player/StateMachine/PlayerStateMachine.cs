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
    public void OnCollisionEnter(Collision collision)
    {
        if(CurrentState is BasePlayerState playerState)
        {
            playerState.OnCollisionEnter(collision);
        }
    }
    public void OnCollisionStay(Collision collision)
    {
        if(CurrentState is BasePlayerState playerState)
        {
            playerState.OnCollisionStay(collision);
        }
        
        
    }
    public void OnCollisionExit(Collision collision)
    {
        if(CurrentState is BasePlayerState playerState)
        {
            playerState.OnCollisionExit(collision);
        }
       
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if(CurrentState is BasePlayerState playerState)
        {
            playerState.OnTriggerEnter(other);
        }
      
    }
   
    public void OnTriggerStay(Collider other)
    {
        if(CurrentState is BasePlayerState playerState)
        {
            playerState.OnTriggerStay(other);
        }
     
    }
    public void OnTriggerExit(Collider other)
    {
        if(CurrentState is BasePlayerState playerState)
        {
            playerState.OnTriggerExit(other);
        }

     
    }
}

