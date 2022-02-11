using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CircleControlUp : MonoBehaviour
{
    public Image circle;

    public float timer = 0f;
    public float setTime;
    // Start is called before the first frame update
    public GameObject miss;
    public GameObject perfect;
    public GameObject good;

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
            //timer = 0;
            Destroy(this.gameObject, 0.5f);
        }
        if (timer > 8 & timer < 10 && Input.GetKey("up"))
        {
            Debug.Log("Perfact");
            perfect.gameObject.SetActive(true);
            Destroy(this.gameObject, 0.5f);
        }
        if (timer > 3 && timer < 8 && Input.GetKey("up"))
        {
            Debug.Log("Good");
            good.gameObject.SetActive(true);
            Destroy(this.gameObject, 0.5f);
        }

    }
}
