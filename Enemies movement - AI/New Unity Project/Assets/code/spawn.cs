using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class spawn : MonoBehaviour
{
    public GameObject nagent;
    public GameObject goalObject;

    void Start()
    {
        Invoke("SpawnAgent", 2);
    }

    void SpawnAgent()
    {
        GameObject na = (GameObject)Instantiate(nagent, this.transform.position, Quaternion.identity);
        na.GetComponent<walkTo>().goal = goalObject.transform;
        Invoke("SpawnAgent", Random.Range(2, 5));
    }
}
