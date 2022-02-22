using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlArrowTop : MonoBehaviour
{
    public Image circle;
    public Image miss;
    public Image good;
    public Image bad;

    float timer = 0f;
    float firstSize;
    void Start()
    {
        circle.GetComponent<Image>();
        firstSize = circle.rectTransform.rect.width;
    }

    public void Update()
    {
        timer += Time.deltaTime;
        circle.rectTransform.sizeDelta = new Vector2(circle.rectTransform.rect.width - (timer), circle.rectTransform.rect.height - (timer));

        DestroyObject();
    }

    void DestroyObject()
    {
        if (circle.rectTransform.rect.width < firstSize && circle.rectTransform.rect.width > firstSize / 2 && Input.GetKeyDown("up"))
        {
            bad.gameObject.SetActive(true);
            CurrentScore.instance.Score(50, 1);
            Song.song.Bad();
            Destroy(good);
            Destroy(miss);
            Destroy(gameObject, 0.3f);
        }
        else if (circle.rectTransform.rect.width < firstSize / 2 && circle.rectTransform.rect.width > firstSize / 3 && Input.GetKeyDown("up"))
        {
            good.gameObject.SetActive(true);
            CurrentScore.instance.Score(100, 1);
            Song.song.Good();
            Destroy(bad);
            Destroy(miss);
            Destroy(gameObject, 0.3f);
        }

        else if (circle.rectTransform.rect.width < firstSize / 3)
        {
            miss.gameObject.SetActive(true);
            CurrentScore.instance.Miss(0);
            Song.song.Miss();
            Destroy(gameObject, 0.3f);
        }

    }
}
