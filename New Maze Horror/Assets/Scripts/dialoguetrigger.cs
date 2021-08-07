using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialoguetrigger : MonoBehaviour
{
    public GameObject fpscam;
    public GameObject dialoguesystem;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            dialoguesystem.SetActive(true);
            fpscam.SetActive(false);
        }
    }
}
