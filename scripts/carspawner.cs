using UnityEngine;

public class carspawner : MonoBehaviour
{
  public float spawnDelay = KeepData.carDelay;

  public GameObject Car;

  public Transform[] spawnPoints;

  private float nextSpawn = 0;
  void Start()
  {

  }

  void Update()
  {
    nextSpawn++;
    if(nextSpawn == KeepData.carDelay)
    {
        SpawnCar();
        nextSpawn = 0;
    }
  }
  void SpawnCar()
  {
    int randomIndex = Random.Range(0, spawnPoints.Length);
    Transform spawnPoint = spawnPoints[randomIndex];

    
    Instantiate(Car , spawnPoint.position, spawnPoint.rotation);
  }
}
