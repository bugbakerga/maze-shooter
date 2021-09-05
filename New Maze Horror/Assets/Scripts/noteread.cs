using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noteread : MonoBehaviour
{
    private bool readytoread;

    public GameObject readprompt;
    public GameObject note;

    public AudioSource audioSource;
    public AudioClip[] clips;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            readytoread = true;
            readprompt.SetActive(true);
        }
    }

    void OnTriggerExit(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            readytoread = false;
            readprompt.SetActive(false);
            note.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    public void buttonend()
    {
        note.SetActive(false);
        readprompt.SetActive(true);
        audioSource.PlayOneShot(clips[1]);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    } 

    // Update is called once per frame
    void Update()
    {
        if(readytoread == true)
        {
            if (Input.GetButtonDown("Ekey"))
            {
                note.SetActive(true);
                audioSource.PlayOneShot(clips[0]);
                readprompt.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }
}
