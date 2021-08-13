using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class campantrigger : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    public float duration;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            cam2.SetActive(true);
            cam1.SetActive(false);
            StartCoroutine(camswitch());
        }
    }

    IEnumerator camswitch()
    {
        yield return new WaitForSeconds(duration);
        cam1.SetActive(true);
        cam2.SetActive(false);
    }
}
