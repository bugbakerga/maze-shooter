using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicDoorManager : MonoBehaviour
{
    public GameObject openDoor;
    public GameObject closedDoor;

    public string dooranswer;
    public string trialcode;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void DoorOpen(string newCodeNumber)
    {
        trialcode += newCodeNumber;
        if(trialcode == dooranswer)
        {
            openDoor.SetActive(true);
            closedDoor.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            audioSource.Play();
            trialcode = "";
        }
    }
}
