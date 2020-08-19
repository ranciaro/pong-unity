using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumber : MonoBehaviour
{
    public bool isBump1;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isBump1)
            transform.Translate(0f, 0f, Input.GetAxis("Player1") * speed * Time.deltaTime);
        else
            transform.Translate(0f, 0f, Input.GetAxis("Player2") * speed * Time.deltaTime);

    }
}
