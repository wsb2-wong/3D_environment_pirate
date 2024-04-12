using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("run", true);
        }

        if(Input.GetKeyUp(KeyCode.Q))
        {
            animator.SetBool("run", false);
        }
    }
}
