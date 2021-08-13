using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHealth : MonoBehaviour
{
    public float hits;
    public CameraShake cameraShake;

    public Animator blood;
    public AudioSource audioSource; 
    public AudioClip clip;

    public deathManager death;

    public void TakePlayerDamage(float damage)
    {
        hits -= damage;
        blood.SetTrigger("squirt");
        audioSource.PlayOneShot(clip);
        StartCoroutine(cameraShake.Shake(.15f, .4f));
        if(hits <= 0.0f)
        {
            cameraShake.stopShake();
            hits = 1f;
            death.Die();
        }
    }
}
