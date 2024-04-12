using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables; // Import the namespace for PlayableDirector

public class fruit_collider : MonoBehaviour
{
    public PlayableDirector fruit; // Correct declaration of PlayableDirector

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnTriggerEnter function should have a Collider parameter to detect collisions
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the player or any other specific object
        if (other.CompareTag("Player")) 
        {
            // Play the assigned timeline when triggered
            fruit.Play(); // corrected cutscene to fruit
        }
    }
}
