using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class fpssequence : MonoBehaviour
{
    public PlayableDirector cutscene;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            cutscene.Play();
        }
    }
}
