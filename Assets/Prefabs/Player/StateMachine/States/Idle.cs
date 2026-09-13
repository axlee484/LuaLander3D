using UnityEngine;

namespace PlayerStates.StateMachine.States
{
    public class Idle : BasePlayerState
    {
        public Idle(PlayerStateId stateId, PlayerContext context) : base(stateId, context){}
    }
}
