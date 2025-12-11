using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] FoundSpawnPoints[] spawnPoints;
    [SerializeField] GameObject[] prefabsObstacles;
    [SerializeField] private float timer, maxTimer;
    void Awake()
    {
        spawnPoints = transform.GetComponentsInChildren<FoundSpawnPoints>();
    }
    private void Start()
    {
        timer = maxTimer;
    }
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            int sp = Random.Range(0, spawnPoints.Length);
            int obs = Random.Range(0, prefabsObstacles.Length);
            Instantiate(prefabsObstacles[obs], spawnPoints[sp].transform);
            timer = maxTimer;
        }
    }
}
