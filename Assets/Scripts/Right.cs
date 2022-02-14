using UnityEngine;

public class Right : MonoBehaviour
{
    float waitingForNextSpawn = 2f;
    float theCountDown = 3;
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
        float spawnX = Random.Range(3, 3);

        // float spawnY = Random.Range
        //        (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y,
        //           Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        // float spawnX = Random.Range
        //        (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x,
        //           Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        Vector2 pos = new Vector2(spawnX, spawnY);

        GameObject arrowPos = spawnArrow[Random.Range(0, spawnArrow.Length)];

        Instantiate(arrowPos, pos, Quaternion.identity);

    }
}