using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelEnd : MonoBehaviour
{
    //ui
    public GameObject fadein;
    public GameObject loadingScreen;

    //time and scene
    public float fadeduration;
    public int nextscene;

    //sfx
    public AudioSource speaker;
    public AudioClip doorNoise;

    void OnTriggerEnter(Collider plyr)
    {
        if (plyr.gameObject.tag == "Player")
        {
            fadein.SetActive(true);
            speaker.PlayOneShot(doorNoise);
            StartCoroutine(sceneload());
        }
    }

    IEnumerator sceneload()
    {
        yield return new WaitForSeconds(fadeduration);
        loadingScreen.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nextscene);
    }
}
