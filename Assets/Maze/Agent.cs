using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    public Transform goal;
    private NavMeshAgent agent;
    private Animator animator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        agent.destination = goal.position;
    }

    void Update()
    {
        animator.SetBool("walking", agent.remainingDistance > agent.stoppingDistance);
        agent.destination = goal.position;
    }
}