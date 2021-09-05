using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bigcanon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;

    public bool readtoShoot;

    public float bulletSpeed;
    public float readySpeed;
    public int destroySpeed;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        readtoShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (readtoShoot == true)
        {
            StartCoroutine(Shooting());
        }
    }

    IEnumerator Shooting()
    {
        readtoShoot = false;
        yield return new WaitForSeconds(readySpeed);
        transform.LookAt(player);
        Fire();
        readtoShoot = true;
    }

    void Fire()
    {
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

        Destroy(bullet, destroySpeed);
    }
}
