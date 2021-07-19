using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GunSystem : MonoBehaviour
{
    // Gun stats
    public int damage;
    public float timeBetweenShooting, spread, range, reloadTime, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;
    int bulletsLeft, bulletsShot;

    //bool
    bool shooting, readyToShoot, reloading;

    //Reference
    public Camera fpsCam;
    public Transform attackPoint;
    public RaycastHit rayhit;
    public LayerMask whatIsEnemy;

    //GFX
    public GameObject shotFlash, bulletHole;
    public TextMeshProUGUI bulletui;

    //SFX
    public AudioSource speaker;
    public AudioClip[] clips;

    private void Awake()
    {
        bulletsLeft = magazineSize;
        readyToShoot = true;
        bulletui.SetText(bulletsLeft + " / " + magazineSize);
    }

    private void Update()
    {
        MyInput();

        //SetText
        bulletui.SetText(bulletsLeft + " / " + magazineSize);
    }

    private void MyInput()
    {
         if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
         else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading) Reload();

        //shoot
        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletsShot = bulletsPerTap;
            Shoot();
        }
    }

    private void Shoot()
    {
        readyToShoot = false;

        //Spread
        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        //Calculate Spread Dir
        Vector3 direction = fpsCam.transform.forward + new Vector3(x, y, 0);

        //RayCast
        if (Physics.Raycast(fpsCam.transform.position, direction, out rayhit, range, whatIsEnemy))
        {
            Debug.Log(rayhit.collider.name);
        }

        Instantiate(bulletHole, rayhit.point, Quaternion.Euler(0, 180, 0));
        Instantiate(shotFlash, attackPoint.position, Quaternion.identity);

        bulletsLeft--;
        bulletsShot--;

        Invoke("ResetShot", timeBetweenShooting);

        if (bulletsShot > 0 && bulletsLeft > 0)
        Invoke("Shoot", timeBetweenShots);
    }

    private void ResetShot()
    {
        readyToShoot = true;
    }

    private void Reload()
    {
        reloading = true;
        speaker.PlayOneShot(clips[0]);
        Invoke("ReloadFinished", reloadTime);
    }

    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }
}
