using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] Transform destination;

    NavMeshAgent navMeshAgent;

    private void Start()
    {
        navMeshAgent = this.GetComponent<NavMeshAgent>();

        if (navMeshAgent == null)
        {
            Debug.Log("There is no Game Object attached");
        }
        else
        {
            SetDestination();
        }

    }

    public void SetDestination()
    {
        if (destination != null)
        {
            Vector3 targetVector = destination.transform.position;
            navMeshAgent.SetDestination(targetVector);
        }
    }



    //public NavMeshAgent agent;

    //public Transform player;

    //public LayerMask whatIsGround, whatIsPlayer;

    //public Vector3 walkPoint;
    //bool walkPointSet;
    //public float walkPointRange;

    //public float sightRange;
    //public bool playerInSightRange;


    //public void Awake()
    //{
    //    player = GameObject.Find("Pekmen").transform;
    //    agent = GetComponent<NavMeshAgent>();
    //}
    //private void Update()
    //{
    //    playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

    //    if (playerInSightRange)
    //    {
    //        ChasePlayer();
    //    }
    //    else
    //    {
    //        Patrolling();
    //    }
    //}

    //private void Patrolling()
    //{
    //    if (!walkPointSet) SearchWalkPoint();

    //    if (walkPointSet)
    //        agent.SetDestination(walkPoint);

    //    Vector3 distanceToWalkPoint = transform.position - walkPoint;

    //    if (distanceToWalkPoint.magnitude < 1f)
    //        walkPointSet = false;

    //}
    //public void SearchWalkPoint()
    //{
    //    float randomZ = Random.Range(-walkPointRange, walkPointRange);
    //    float randomX = Random.Range(-walkPointRange, walkPointRange);

    //    walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

    //    if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
    //        walkPointSet = true;
    //}
    //private void ChasePlayer()
    //{
    //    agent.SetDestination(player.position);
    //}

    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(transform.position, sightRange);
    //}
}
