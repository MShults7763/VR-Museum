using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audioClip; // Audio clip to play
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to this object
        audioSource = GetComponent<AudioSource>();

        // Ensure an audio clip is set and an AudioSource component is attached
        if (audioClip == null || audioSource == null)
        {
            Debug.LogError("AudioClip or AudioSource component is missing.");
            return;
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider's game object has the "AmongUs" tag
        if (other.gameObject.CompareTag("AmongUs"))
        {
            // Play the audio clip
            audioSource.PlayOneShot(audioClip);
        }
    }
}
