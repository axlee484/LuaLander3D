using UnityEngine;

namespace PlayerStates.StateMachine.States
{
    public class Dead : BasePlayerState
    {
        public Dead(PlayerStateId stateId, PlayerContext context) : base(stateId, context){}
    }
}
