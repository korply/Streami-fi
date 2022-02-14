using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleControlLeft : MonoBehaviour
{
    public Image circle;
    public float timer = 0f;
    public float setTime;
    public GameObject miss;
    public GameObject perfect;
    public GameObject good;
    public GameObject canvasDelete;

    void Start()
    {
        circle.GetComponent<Image>();
    }

    void Update()
    {
        timer += Time.deltaTime * 10;
        circle.rectTransform.sizeDelta = new Vector2(15 - (timer), 15 - (timer));

        if (timer > 10)
        {
            Debug.Log("Miss");
            miss.gameObject.SetActive(true);
            Destroy(canvasDelete, 0.5f);
        }
        if (timer > 8 & timer < 10 && Input.GetKey("left"))
        {
            Debug.Log("Perfact");
            perfect.gameObject.SetActive(true);
            Destroy(canvasDelete, 0.5f);
        }
        if (timer > 3 && timer < 8 && Input.GetKey("left"))
        {
            Debug.Log("Good");
            good.gameObject.SetActive(true);
            Destroy(canvasDelete, 0.5f);
        }

    }
}
