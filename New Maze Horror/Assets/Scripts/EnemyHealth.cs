using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public float newlookrad;

    public GameObject explosion;
    public Enemycontroller theai;

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
            Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
