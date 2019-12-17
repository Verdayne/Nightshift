using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField]
    private Transform[] spawnPoints = null;
    [SerializeField]
    private GameObject objectToSpawn = null;

    [SerializeField]
    private GameObject target = null;

    [SerializeField]
    private float spawnRate = 1;

    private float timeToSpawn = 0;


    private void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            timeToSpawn = Time.time + 1 / spawnRate;
            SpawnRandomAI();
        }
    }


    void SpawnRandomAI()
    {
        var spawnPoint = spawnPoints[Random.Range(0, 3)];
        var agent = Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);
        var mind = agent.GetComponent<WalkToAI>();
        mind.Target = target.transform;
    }
}
