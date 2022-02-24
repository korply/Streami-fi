using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spot : MonoBehaviour
{
    
         public float rotateSpeed = 10f;
          public int  anger = 1;
         float xangle;
          float zangle;
        // Use this for initialization
       void Start () {
           float xangle = transform.rotation.x;
           float zangle = transform.rotation.z;
        }
 
 // Update is called once per frame
        void Update () {
            transform.Rotate(new Vector3(xangle, anger*Time.deltaTime*rotateSpeed, zangle));
          
       }
   }

