using UnityEngine;


public class PlayerMovementAuido : MonoBehaviour
{
    [SerializeField] private AudioSource _walkAudioSource;
    [SerializeField] private AudioSource _runAudioSource;

    public void RunStepSound()
    {
        _runAudioSource.Play();
    }

    public void WalkStepSound()
    {
        _walkAudioSource.Play();
    }
}