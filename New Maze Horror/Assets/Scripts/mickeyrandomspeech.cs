using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mickeyrandomspeech : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] voicelines;

    int thenum;

    void Awake()
    {
        thenum = Random.Range(0, voicelines.Length);
        audioSource.PlayOneShot(voicelines[thenum]);
    }
}
