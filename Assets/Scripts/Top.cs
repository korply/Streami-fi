using UnityEngine;

public class Top : MonoBehaviour
{
    float waitingForNextSpawn = 1.5f;
    float theCountDown = 4;
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
        float spawnY = Random.Range(3, 3);
        float spawnX = Random.Range(-1.5f, 1.5f);

        Vector2 pos = new Vector2(spawnX, spawnY);

        GameObject arrowPos = spawnArrow[Random.Range(0, spawnArrow.Length)];

        Instantiate(arrowPos, pos, Quaternion.identity);

    }
}