using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class WednesdayParticleTrigger : MonoBehaviour
{
    private ParticleSystem particleSystem;
    public int particleAmount = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>())
        {
            particleSystem.Emit(particleAmount);
        }
    }
}
