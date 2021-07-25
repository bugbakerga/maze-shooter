using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potioncollect : MonoBehaviour
{
    public potionlogic potioncont;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            potioncont.potionEffects();
        }
    }
}
