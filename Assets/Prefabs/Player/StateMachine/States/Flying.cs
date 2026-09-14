using System;
using System.Collections;
using UnityEngine;

namespace PlayerStates.StateMachine.States
{
    public class Flying : BasePlayerState
    {
        private RigidBodyMovement rigidBodyMovement;
        private AudioSource audioSource;
        public Flying(PlayerStateId stateId, PlayerContext context) : base(stateId, context)
        {
            rigidBodyMovement = Context.player.GetComponent<RigidBodyMovement>();
            audioSource = Context.player.GetComponent<AudioSource>();
        }
        public override void Enter()
        {
            audioSource.Play();
            Context.playerVisuals.PlayThrustParticles(true);
            // Debug.Log("Entering Flying "+ audioSource.volume);
        }
        public override void FixedUpdate()
        {
            var (forwardInput, rotationInput) = GetInput();
            if((forwardInput, rotationInput) == (0,0)) 
            {
                InvokeChangeState(PlayerStateId.Idle);
                return;
            }
            rigidBodyMovement.Move(Vector3.up * Math.Sign(forwardInput), true);
            rigidBodyMovement.Rotate(-Vector3.forward * Math.Sign(rotationInput));
        }

        private IEnumerator FadeOut(AudioSource audioSource, float duration)
        {
            audioSource.volume = Mathf.Lerp(audioSource.volume, 0, duration);
            yield return new WaitForSeconds(duration);
            audioSource.Stop();
        }
        public override void Exit()
        {
            // AudioManager.Instance.FadeAudioSource(audioSource, 1f);
            audioSource.Stop();
            Context.playerVisuals.PlayThrustParticles(false);
        }

        public override void OnCollisionEnter(Collision collision)
        {
            Context.player.DisableInput();
        }
        
    }
}
