using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AII_Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int attackRage = 2;
    NavMeshAgent agent;
    GameObject generator;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        generator = GameObject.Find("Generator");
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(generator.transform.position);
    }

    void attack()
    {
        if(agent.remainingDistance <= attackRage)
        {
            //attack code
        }
    }
}
