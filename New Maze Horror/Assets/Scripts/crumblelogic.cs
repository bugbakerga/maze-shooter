using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crumblelogic : MonoBehaviour
{
    public GameObject crumblefx;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(crumblefx, transform.position, Quaternion.identity);
        }
    }
}
