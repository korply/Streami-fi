using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPosition : MonoBehaviour
{
    public float waitingForNextSpawn = 5f;
    public float theCountDown = 5;
    // Start is called before the first frame update
    public GameObject[] spawnArrow;
    //RectTransform ractPos;

    void Start()
    {
        //ractPos = gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
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

        float spawnY = Random.Range
               (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).y, Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height)).y);
        float spawnX = Random.Range
            (Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x, Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x);

        //    Vector2 pos = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin,yMax));
        Vector2 pos = new Vector2(spawnX, spawnY);

        GameObject arrowPos = spawnArrow[Random.Range(0, spawnArrow.Length)];

        Instantiate(arrowPos, pos, Quaternion.identity);

    }
}