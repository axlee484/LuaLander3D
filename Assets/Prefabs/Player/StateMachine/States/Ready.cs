using UnityEngine;

namespace PlayerStates.StateMachine.States
{
    public class Ready : BasePlayerState
    {
        public Ready(PlayerStateId stateId, PlayerContext context) : base(stateId, context){}
        
        public override void Update()
        {
            var input = GetInput();
        }
    }
}
