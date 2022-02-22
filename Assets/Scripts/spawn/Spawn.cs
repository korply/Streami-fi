using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    float NextSpawnT = 1.5f;
    float NextSpawnD = 4f;
    float NextSpawnL = 3.5f;
    float NextSpawnR = 2f;
    float theCountTop = 4;
    float theCountDown = 3;
    float theCountLeft = 2;
    float theCountRight = 1;
    public GameObject Top;
    public GameObject Down;
    public GameObject Left;
    public GameObject Right;

    void Update()
    {
        theCountTop -= Time.deltaTime;
        theCountDown -= Time.deltaTime;
        theCountLeft -= Time.deltaTime;
        theCountRight -= Time.deltaTime;
        if (theCountTop <= 0)
        {
            SpawnTop();
            theCountTop = NextSpawnT;
        }
        if (theCountDown <= 0)
        {
            SpawnDown();
            theCountDown = NextSpawnD;
        }
        if (theCountLeft <= 0)
        {
            SpawnLeft();
            theCountLeft = NextSpawnL;
        }
        if (theCountRight <= 0)
        {
            SpawnRight();
            theCountRight = NextSpawnR;
        }

    }
    void SpawnTop()
    {
        
        Vector2 posTop = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(1.3f, 1.3f));
        Instantiate(Top, posTop, Quaternion.identity);
    }

    void SpawnLeft()
    {
        Vector2 posLeft = new Vector2(Random.Range(-0.3f, -0.3f), Random.Range(0.5f, 1f));
        Instantiate(Left, posLeft, Quaternion.identity);
    }
    void SpawnRight()
    {
        Vector2 posRight = new Vector2(Random.Range(0.3f, 0.3f), Random.Range(0.5f, 1f));
        Instantiate(Right, posRight, Quaternion.identity);
    }
    void SpawnDown()
    {
        Vector2 posDown = new Vector2(Random.Range(-0.2f, 0.2f), Random.Range(0.4f, 0.4f));
        Instantiate(Down, posDown, Quaternion.identity);
    }

}