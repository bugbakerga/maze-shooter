using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mickeythreat : MonoBehaviour
{
    public float damage;
    public AudioSource audioSource;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            plyr.gameObject.GetComponent<MainHealth>().TakePlayerDamage(damage);
            audioSource.Stop();
        }
    }
}
