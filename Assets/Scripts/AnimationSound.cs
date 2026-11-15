using UnityEngine;

public class AnimationSound : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip sound;

    public void PlaySound()
    {
        audioSource.PlayOneShot(sound);
    }
}
