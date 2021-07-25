using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionlogic : MonoBehaviour
{
    public Camera thecam;
    public GameObject postpro;

    //lerping
    public float narrowview;
    public float wideview;

    public void potionEffects()
    {
        thecam.fieldOfView = wideview;
        postpro.SetActive(true);
        StartCoroutine(resetpotion());
    }

    IEnumerator resetpotion()
    {
        yield return new WaitForSeconds(5);
        thecam.fieldOfView = narrowview;
        postpro.SetActive(false);
    }
}
