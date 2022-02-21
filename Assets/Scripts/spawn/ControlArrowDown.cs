using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlArrowDown : MonoBehaviour
{
    public SpriteRenderer circle;
    public SpriteRenderer miss;
    public SpriteRenderer perfact;
    public SpriteRenderer good;


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
            timer = 0;
            miss.gameObject.SetActive(true);
            CurrentScore.instance.Miss(0);
            Song.song.Miss();
            Destroy(gameObject, 0.2f);
        }
        if (timer > 1f && timer < 1.2 && Input.GetKeyDown("down"))
        {
            perfact.gameObject.SetActive(true);
            CurrentScore.instance.Score(100, 1);
            Song.song.Good();
            Destroy(miss);
            Destroy(good);
            Destroy(gameObject, 0.2f);
        }
        if (timer > 0.1f && timer < 0.99f && Input.GetKeyDown("down"))
        {
            good.gameObject.SetActive(true);
            CurrentScore.instance.Score(50, 1);
            Song.song.Bad();
            Destroy(miss);
            Destroy(perfact);
            Destroy(gameObject, 0.2f);
        }

    }

}
