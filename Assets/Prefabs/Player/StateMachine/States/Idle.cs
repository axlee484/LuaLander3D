using UnityEngine;

namespace PlayerStates.StateMachine.States
{
    public class Idle : BasePlayerState
    {
        public Idle(PlayerStateId stateId, PlayerContext context) : base(stateId, context){}
        public override void Enter()
        {
            Context.player.TryGetComponent<Rigidbody>(out var rigidbody);
            rigidbody.useGravity = true;
        }
        public override void Update()
        {
            var (forwardInput, rotationInput) = GetInput();
            if(forwardInput != 0 || rotationInput != 0) InvokeChangeState(PlayerStateId.Flying);
        }
    }
}
