using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy2Controller : MonoBehaviour
{
    public Transform[] waypoints;

    public float lookRadius = 10f;

    private int waypointIndex;
    private float dist;

    public Animator anim;

    Transform target;
    NavMeshAgent agent;

    bool readytorun;
    public float speed1;
    public float speed2;

    // Start is called before the first frame update
    void Start()
    {
        target = Playermanager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        waypointIndex = 0;
        readytorun = true;
        agent.speed = speed1;
        IncreaseIndex();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.isStopped = false;
            agent.SetDestination(target.position);
        }


        dist = Vector3.Distance(transform.position, waypoints[waypointIndex].position);
        if (dist < 4f)
        {
            IncreaseIndex();
        }

        if (distance > lookRadius)
        {
            agent.SetDestination(waypoints[waypointIndex].position);
        }

        if(readytorun == true)
        {
            StartCoroutine(attack());
        }

    }

    void IncreaseIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
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

    IEnumerator attack()
    {
        readytorun = false;
        agent.speed = speed1;
        yield return new WaitForSeconds(4);
        anim.SetBool("isrunning", true);
        agent.speed = speed2;
        yield return new WaitForSeconds(0.8f);
        anim.SetBool("isrunning", false);
        agent.speed = speed1;
        readytorun = true;
    }
}
