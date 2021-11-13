using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource walksound;

    // Update is called once per frame
    void Update()
    {
        CheckForPlayerInput();
    }

    void CheckForPlayerInput()
    {
        if (Mathf.Abs(Input.GetAxis("Vertical")) > 0 ||
        Mathf.Abs(Input.GetAxis("Horizontal")) > 0)
        {
            walksound.Stop();
        }

        else
        {
            walksound.Play();
        }
    }
}
