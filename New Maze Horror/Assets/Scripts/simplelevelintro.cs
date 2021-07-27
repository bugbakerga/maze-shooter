using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplelevelintro : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;

    public bool playonawake;
    public float transitiondur;

    void Awake()
    {
        if (playonawake == true)
        {
            Invoke("camTransition", 0.1f);
        }
    }

    public void camTransition()
    {
        cam2.SetActive(true);
        cam1.SetActive(false);
        StartCoroutine(camSequence());
    }

    IEnumerator camSequence()
    {
        yield return new WaitForSeconds(transitiondur);
        cam1.SetActive(true);
        cam2.SetActive(false);
    }


}
