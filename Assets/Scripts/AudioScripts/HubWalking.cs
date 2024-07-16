using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubWalking : MonoBehaviour
{
    public AudioClip walkingAudio; // Reference to the AudioSource component
    public PlayerController playerController;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        // Assign the AudioClip to the AudioSource
        audioSource.clip = walkingAudio;

        // Play the audio
        audioSource.Play();
        audioSource.loop = true; // Set the audio to loop
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.isMoving)
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
