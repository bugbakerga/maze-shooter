using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemycontroller : MonoBehaviour
{
    public Transform[] waypoints;

    public float lookRadius = 10f;
    public float attackRadius = 5f;

    private int waypointIndex;
    private float dist;

    public Animator anim;

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

        if (distance <= lookRadius && distance > attackRadius)
        {
            agent.isStopped = false;
            agent.SetDestination(target.position);
        }

        if (distance < attackRadius)
        {
            agent.isStopped = true;
            anim.SetTrigger("attack");
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
        Gizmos.DrawWireSphere(transform.position, attackRadius);
    }

    public void Speedup()
    {
        agent.speed += 0.5f; 
    }
}
