using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHealth : MonoBehaviour
{
    private int hits;
    public CameraShake cameraShake;

    public Animator blood;

    public void TakePlayerDamage()
    {
        hits -= 1;
        blood.SetTrigger("squirt");
        StartCoroutine(cameraShake.Shake(.15f, .4f));
    }
}
