using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostdisapear : MonoBehaviour
{
    public GameObject richard;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(richard);
        }
    }
}
