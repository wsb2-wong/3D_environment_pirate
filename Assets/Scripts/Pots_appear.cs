using UnityEngine;

public class StumpTrigger : MonoBehaviour
{
    public GameObject potsRound; // Reference to the Pots_round GameObject
    public AudioSource spaceshipSound; // Reference to the AudioSource component for the spaceship sound
    private bool hasPlayerTriggered = false; // Flag to track if the player has triggered the stump

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasPlayerTriggered)
        {
            hasPlayerTriggered = true; // Player has triggered the stump for the first time
            ShowPotsRound(); // Show the Pots_round GameObject
            PlaySpaceshipSound(); // Play the spaceship sound
        }
    }

    private void HidePotsRound()
    {
        potsRound.SetActive(false); // Hide the Pots_round GameObject
    }

    private void ShowPotsRound()
    {
        potsRound.SetActive(true); // Show the Pots_round GameObject
    }

    private void PlaySpaceshipSound()
    {
        spaceshipSound.Play(); // Play the spaceship sound
    }

    // Start is called before the first frame update
    void Start()
    {
        HidePotsRound(); // Initially hide the Pots_round GameObject
        spaceshipSound.Stop(); // Ensure the sound is stopped initially
    }
}
