using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MickeyBoss : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;

    public Transform[] spawnpoints;
    public int randomspawnno;

    public GameObject smoke;

    // Start is called before the first frame update
    void Start()
    {
        target = Playermanager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }

    public void mickeyhit()
    {
        randomspawnno = Random.Range(0, spawnpoints.Length);
        Instantiate(smoke, transform.position, Quaternion.identity);
        transform.position = spawnpoints[randomspawnno].position;
        agent.speed = 0;
        StartCoroutine(cooldown());
    }

    IEnumerator cooldown()
    {
        yield return new WaitForSeconds(6);
        agent.speed = 20;
    }
}
