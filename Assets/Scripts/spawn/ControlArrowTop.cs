using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlArrowTop : MonoBehaviour
{
    public SpriteRenderer circle;
    public SpriteRenderer miss;
    public SpriteRenderer perfact;
    public SpriteRenderer good;


    int score;

    float timer = 0f;
    void Start()
    {
        circle.drawMode = SpriteDrawMode.Sliced;
    }

    void Update()
    {
        timer += Time.deltaTime;
        circle.size = new Vector2(1.5f - (timer), 1.5f - (timer));

        if (timer > 1.3)
        {
            Destroy(gameObject, 0.2f);
            miss.gameObject.SetActive(true);
        }
        if (timer > 1f && timer < 1.2 && Input.GetKeyDown("up"))
        {
            perfact.gameObject.SetActive(true);
            Destroy(miss);
            Destroy(good);
            Destroy(gameObject, 0.2f);
        }
        if (timer > 0.5f && timer < 0.8f && Input.GetKeyDown("up"))
        {
            good.gameObject.SetActive(true);
            Destroy(miss);
            Destroy(perfact);
            Destroy(gameObject, 0.2f);
        }

    }
}
