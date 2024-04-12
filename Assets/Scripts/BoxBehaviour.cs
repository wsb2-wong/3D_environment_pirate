using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : MonoBehaviour
{
    public AudioClip boxOpening;
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component attached to the game object
        audioSource = GetComponent<AudioSource>();
        
        // Make sure the AudioClip is assigned to the AudioSource
        if (boxOpening != null && audioSource != null)
        {
            audioSource.clip = boxOpening;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) // CompareTag is more efficient than comparing strings
        {
            // Check if the audio source and audio clip are not null before playing
            if (audioSource != null && audioSource.clip != null)
            {
                audioSource.PlayOneShot(boxOpening);
            }
        }
    }
}
