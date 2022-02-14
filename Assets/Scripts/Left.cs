using UnityEngine;

public class Left : MonoBehaviour
{
    float waitingForNextSpawn = 3.5f;
    float theCountDown = 2;
    public GameObject[] spawnArrow;

    void Update()
    {
        theCountDown -= Time.deltaTime;
        if (theCountDown <= 0)
        {
            SpawnArrown();
            theCountDown = waitingForNextSpawn;
        }
    }

    void SpawnArrown()
    {
        float spawnY = Random.Range(-2, 2);
        float spawnX = Random.Range(-3, -3);

        Vector2 pos = new Vector2(spawnX, spawnY);

        GameObject arrowPos = spawnArrow[Random.Range(0, spawnArrow.Length)];

        Instantiate(arrowPos, pos, Quaternion.identity);

    }
}