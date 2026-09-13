using UnityEngine;

namespace PlayerStates.StateMachine.States
{
    public class Flying : BasePlayerState
    {
        public Flying(PlayerStateId stateId, PlayerContext context) : base(stateId, context){}
    }
}
