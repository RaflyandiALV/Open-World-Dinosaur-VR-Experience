using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomMovement : MonoBehaviour
{
    public float roamRadius = 10f;
    public float roamDelay = 2f;
    private NavMeshAgent agent;
    private Animator animator;
    private float timer;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        timer = roamDelay;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= roamDelay)
        {
            Vector3 newPos = RandomNavSphere(transform.position, roamRadius, -1);
            agent.SetDestination(newPos);
            timer = 0;
        }

        // Play walking animation if the animal is moving
        animator.SetBool("isWalking", agent.velocity.magnitude > 0.1f);
    }

    public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
    {
        Vector3 randomDirection = UnityEngine.Random.insideUnitSphere * dist; // Ubah menjadi UnityEngine.Random

        randomDirection += origin;

        NavMeshHit navHit;

        NavMesh.SamplePosition(randomDirection, out navHit, dist, layermask);

        return navHit.position;
    }
}
