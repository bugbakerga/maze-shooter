using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Cutsceneplayer : MonoBehaviour
{
    public GameObject player;
    public GameObject cam2;
    public float cutsceneduration;

    public PlayableDirector cutscene;
    public bool PlayOnAwake;

    void Awake()
    {
        if (PlayOnAwake == true)
        {
            startCutscene();
        }
    }

    public void startCutscene()
    {
        cutscene.Play();
        player.SetActive(false);
        StartCoroutine(endcutscene());
    }

    IEnumerator endcutscene()
    {
        yield return new WaitForSeconds(cutsceneduration);
        player.SetActive(true);
        cam2.SetActive(false);
    }
}
