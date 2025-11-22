using UnityEngine;

public class RecorderFix : MonoBehaviour
{
    private ParticleSystem mainParticleSystem;

    void Awake()
    {
        mainParticleSystem = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        // Manually trigger the particle system's update logic
        // This is a powerful, low-level function.
        mainParticleSystem.Simulate(Time.unscaledDeltaTime, true, false, true);
    }
}