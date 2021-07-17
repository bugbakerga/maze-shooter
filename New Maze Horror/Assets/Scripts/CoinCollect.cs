using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public CoinSystem coinSystem;
    public AudioSource speaker;
    public AudioClip sound;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            speaker.PlayOneShot(sound);
            coinSystem.addCoin();
            Destroy(gameObject);
        }
    }
}
