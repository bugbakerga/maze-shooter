using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundplay : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            audioSource.Play();
        }
    }
}
