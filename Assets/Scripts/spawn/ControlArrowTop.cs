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
    Score sCore;


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
            miss.gameObject.SetActive(true);
            Score.instance.NoteMissed();
            Destroy(gameObject, 0.2f);
        }
        if (timer > 1f && timer < 1.2  && Input.GetKeyDown("up"))
        {
            perfact.gameObject.SetActive(true);
            Score.instance.NoteHitPerfact();
            Destroy(miss);
            Destroy(good);
            Destroy(gameObject, 0.2f);
        }
        if (timer > 0.1f && timer < 0.99f && Input.GetKeyDown("up"))
        {
            good.gameObject.SetActive(true);
            Score.instance.NoteHitGood();
            Destroy(miss);
            Destroy(perfact);
            Destroy(gameObject, 0.2f);
        }

    }
}
