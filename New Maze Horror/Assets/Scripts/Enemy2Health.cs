using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Health : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public bool partofmission;

    public GameObject explosion;
    public enemyWaveManager enemyWave;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int takeaway)
    {
        currentHealth -= takeaway;
        if (currentHealth < 1)
        {
            if (partofmission == true)
            {
                enemyWave.ghostKill();
            }
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
