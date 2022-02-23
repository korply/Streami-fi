using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    float NextSpawnT = 2.5f;
    float NextSpawnD = 4f;
    float NextSpawnL = 3.5f;
    float NextSpawnR = 2f;
    float theCountTop = 9;
    float theCountDown = 8;
    float theCountLeft = 7;
    float theCountRight = 6;
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
        Vector2 posTop = new Vector2(Random.Range(900, 1100),900);
        var topSpawn =   Instantiate(Top, posTop, Quaternion.identity);
         topSpawn.transform.parent = gameObject.transform;

    }
    void SpawnLeft()
    {
        Vector2 posLeft = new Vector2(600, Random.Range(500, 600));
         var leftSpawn = Instantiate(Left, posLeft, Quaternion.identity);
         leftSpawn.transform.parent = gameObject.transform;
    }
    void SpawnRight()
    {
        Vector2 posRight = new Vector2(1300, Random.Range(500, 600));
        var rightSpawn =  Instantiate(Right, posRight, Quaternion.identity);
          rightSpawn.transform.parent = gameObject.transform;
    }
    void SpawnDown()
    {
        Vector2 posDown = new Vector2(Random.Range(900, 1100), 300);
        var downSpawn =   Instantiate(Down, posDown, Quaternion.identity);
          downSpawn.transform.parent = gameObject.transform;
    }

}