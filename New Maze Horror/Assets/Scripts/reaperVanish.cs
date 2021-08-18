using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reaperVanish : MonoBehaviour
{
    public GameObject reaper;
    public GameObject smoke;

    public Transform smokeSpawn;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(reaper);
            Instantiate(smoke, smokeSpawn.position, Quaternion.identity);
        }
    }
}
