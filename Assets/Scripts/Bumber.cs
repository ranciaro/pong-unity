using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumber : MonoBehaviour
{
    public bool isBump1;
    public float speed = 5f;
    public float MaxZIndex = 5.8f;
    public float MinZIndex = -5.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isBump1)
            transform.Translate(0f, 0f, ValidateRange(Input.GetAxis("Player1") * speed * Time.deltaTime, MinZIndex, MaxZIndex));
        else
            transform.Translate(0f, 0f, Input.GetAxis("Player2") * speed * Time.deltaTime);
    }

    private float ValidateRange(float zIndex, float minZIndex, float maxZIndex)
    {
        if (transform.localPosition.z <= minZIndex && zIndex < 0)
            zIndex = 0;
        else if (transform.localPosition.z >= maxZIndex && zIndex > 0)
            zIndex = 0;
        return zIndex;
    }
}
