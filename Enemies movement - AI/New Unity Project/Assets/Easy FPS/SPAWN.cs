using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Surface;
    public GameObject goalObject;

    void Start ()
    {
      Invoke ("SpawnAgent", 2)
    }

    void SpawnAgent()
    {
        GameObject sur = (GameObject)Instantiate(Surface, this.transform.position, Quaternion.identity);
        sur.GetComponent<WALKTO>().goal = goalObject.transform;
        Invoke("SpawnAgent", Random.Range(2, 5));
    }
}
