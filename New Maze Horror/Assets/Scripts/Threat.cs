using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Threat : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            plyr.gameObject.GetComponent<MainHealth>().TakePlayerDamage(damage);
        }
    }
}
