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
            hasPlayerTriggered = true; 
            ShowPotsRound(); 
            PlaySpaceshipSound(); 
        }
    }

    private void HidePotsRound()
    {
        potsRound.SetActive(false); 
    }

    private void ShowPotsRound()
    {
        potsRound.SetActive(true); 
    }

    private void PlaySpaceshipSound()
    {
        spaceshipSound.Play(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        HidePotsRound(); 
        spaceshipSound.Stop(); 
    }
}
