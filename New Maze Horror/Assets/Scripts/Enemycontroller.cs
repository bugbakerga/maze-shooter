using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemycontroller : MonoBehaviour
{
    public Transform[] waypoints;

    public float lookRadius = 10f;

    private int waypointIndex;
    private float dist;

    Transform target;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        target = Playermanager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        waypointIndex = 0;
        IncreaseIndex();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }

        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if(dist < 4f)
        {
            IncreaseIndex();
        }

        if (distance > lookRadius)
        {
            agent.SetDestination(waypoints[waypointIndex].position);
        }

    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if(waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
        agent.SetDestination(waypoints[waypointIndex].position);
    }


    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    public void Speedup()
    {
        agent.speed += 0.5f; 
    }
}
