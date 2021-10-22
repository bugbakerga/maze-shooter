using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;

public class MickeyBoss : MonoBehaviour
{
    Transform target;
    NavMeshAgent agent;

    public Transform[] spawnpoints;
    public int randomspawnno;

    public GameObject smoke;

    public int hits;
    public PlayableDirector cutscene;
    public GameObject thePlayer;

    public float raiseradius;
    public Animator theanim;

    // Start is called before the first frame update
    void Start()
    {
        target = Playermanager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        agent.SetDestination(target.position);
        if (distance <= raiseradius)
        {
            theanim.SetBool("attacking", true);
        }
        else
        {
            theanim.SetBool("attacking", false);
        }
    }


    public void mickeyhit()
    {
        hits -= 1;
        randomspawnno = Random.Range(0, spawnpoints.Length);
        Instantiate(smoke, transform.position, Quaternion.identity);
        transform.position = spawnpoints[randomspawnno].position;
        agent.speed = 0;
        StartCoroutine(cooldown());
        if(hits == 0)
        {
            cutscene.Play();
            thePlayer.SetActive(false);
            Destroy(gameObject);
        }
        
    }

    IEnumerator cooldown()
    {
        yield return new WaitForSeconds(6);
        agent.speed = 20;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, raiseradius);
    }
}
