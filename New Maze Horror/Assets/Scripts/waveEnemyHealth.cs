using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveEnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public float newlookrad;

    public GameObject explosion;
    public Enemycontroller theai;

    public enemyWaveManager waveManager;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int takeaway)
    {
        currentHealth -= takeaway;
        theai.lookRadius = newlookrad;
        if (currentHealth < 1)
        {
            waveManager.ghostKill();
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
