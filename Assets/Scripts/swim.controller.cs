using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swimController : MonoBehaviour
{
    public Animator animator;

    // OnTriggerEnter is called when a collider enters the trigger collider attached to this object
    void OnTriggerEnter(Collider other)
    {
        // Check if the collider entering is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Start the swim animation
            animator.SetBool("swim", true);
        }
    }

    // OnTriggerExit is called when a collider exits the trigger collider attached to this object
    void OnTriggerExit(Collider other)
    {
        // Check if the collider exiting is tagged as "Player"
        if (other.CompareTag("Player"))
        {
            // Stop the swim animation
            animator.SetBool("swim", false);
        }
    }
}
