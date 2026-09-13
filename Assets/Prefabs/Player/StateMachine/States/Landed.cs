using UnityEngine;

namespace PlayerStates.StateMachine.States
{
    public class Landed : BasePlayerState
    {
        public Landed(PlayerStateId stateId, PlayerContext context) : base(stateId, context){}
    }
}
