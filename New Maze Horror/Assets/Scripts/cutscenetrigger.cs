using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class cutscenetrigger : MonoBehaviour
{
    public PlayableDirector cutscene;
    public GameObject thePlayer;
    public GameObject lucky;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            cutscene.Play();
            thePlayer.SetActive(false);
            lucky.SetActive(false);
        }
    }
}
