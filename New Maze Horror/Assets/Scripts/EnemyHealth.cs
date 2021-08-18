using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public float newlookrad;
    public bool partofmission;

    public GameObject explosion;
    public Enemycontroller theai;
    public enemyWaveManager enemyWave;

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
            if(partofmission == true)
            {
                enemyWave.ghostKill();
            }
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
