using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest_behaviour : MonoBehaviour
{
    public Animator animator;
    public GameObject ui;

    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("open");
            ShowUI(); 
            StartCoroutine(HideUIDelay(8f)); // Start coroutine to hide UI after 8 seconds
            StartCoroutine(TriggerDanceDelay(8f)); // Start coroutine to trigger dance animation after 8 seconds
        }
    }

    private IEnumerator HideUIDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for specified delay
        HideUI(); // Hide the UI after delay
    }

    private IEnumerator TriggerDanceDelay(float delay)
    {
        yield return new WaitForSeconds(delay); // Wait for specified delay
        animator.SetTrigger("dance"); // Trigger the dance animation after delay
    }

    private void HideUI()
    {
        ui.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void ShowUI()
    {
        ui.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
