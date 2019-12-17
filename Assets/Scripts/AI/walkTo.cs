using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class WalkToAI : MonoBehaviour
{
    public Transform Target {set; get;}
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if(agent)
        {
            agent.SetDestination(Target.position);
        }  
    }
}
