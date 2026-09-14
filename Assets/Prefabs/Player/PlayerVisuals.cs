using UnityEngine;

public class PlayerVisuals : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] thrustParticleSystems;
    [SerializeField] private ParticleSystem successParticleSystem;
    [SerializeField] private ParticleSystem crashParticleSystem;
    private void Awake()
    {
        PlayThrustParticles(false);
        PlayCrashParticles(false);
        PlaySuccessParticles(false);
    }

    private void SetEmission(ParticleSystem particleSystem, bool active)
    {
        // var emissonModule= particleSystem.emission;
        // emissonModule.enabled = active;
        if(active) particleSystem.Play();
        else particleSystem.Stop();
    }
    public void PlayThrustParticles(bool active)
    {
        for(int i = 0; i < thrustParticleSystems.Length; i++)
        {
            SetEmission(thrustParticleSystems[i], active);
        }
    }
    public void PlayCrashParticles(bool active)
    {
        SetEmission(crashParticleSystem, active);
    }
    public void PlaySuccessParticles(bool active)
    {
        SetEmission(successParticleSystem, active);
    }


    
}
