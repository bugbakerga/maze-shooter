using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWaveManager : MonoBehaviour
{
    public GameObject objectivetext;
    public GameObject wintext;
    public GameObject blocker;
    public GameObject ghostparent;

    public AudioSource audioSource;
    public AudioClip winDing;

    public int totalGhosts;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            ghostparent.SetActive(true);
            objectivetext.SetActive(true);
            StartCoroutine(objectivenoti());
        }
    }

    public void ghostKill()
    {
        totalGhosts -= 1; 
        if(totalGhosts == 0)
        {
            wintext.SetActive(true);
            blocker.SetActive(false);
            audioSource.PlayOneShot(winDing);
            StartCoroutine(endnoti());
        }
    }

    IEnumerator objectivenoti()
    {
        yield return new WaitForSeconds(5);
        objectivetext.SetActive(false);
    }

    IEnumerator endnoti()
    {
        yield return new WaitForSeconds(5);
        wintext.SetActive(false);
    }
}
