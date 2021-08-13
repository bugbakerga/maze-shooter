using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetpos : MonoBehaviour
{
    private Vector3 playerpos;
    private Quaternion playerrot;

    // Start is called before the first frame update
    void Start()
    {
        playerpos = transform.position;
        playerrot = transform.rotation;
    }

    public void respawn()
    {
        transform.position = playerpos;
        transform.rotation = playerrot;
    }

}
