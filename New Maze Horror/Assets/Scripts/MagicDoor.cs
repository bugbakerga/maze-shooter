using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicDoor : MonoBehaviour
{
    public string doorOrder;
    private bool isOverlaping;

    public GameObject keyui;
    public MagicDoorManager doorlogic;

    private AudioSource audioSource;
    public AudioClip knocksound;

    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            keyui.SetActive(true);
            isOverlaping = true;
        }
    }

    void OnTriggerExit(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            keyui.SetActive(false);
            isOverlaping = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isOverlaping == true)
        {
            if(Input.GetButtonDown("Ekey"))
            {
                doorlogic.DoorOpen(doorOrder);
                audioSource.PlayOneShot(knocksound);
            }
        }
    }
}
