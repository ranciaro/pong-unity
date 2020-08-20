using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperAI : MonoBehaviour
{
    public float Velocity = 5f;
    public Transform Ball;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.localPosition.z < transform.localPosition.z)
            transform.localPosition += new Vector3(0, 0, -Velocity * Time.deltaTime);
        if (Ball.localPosition.z > transform.localPosition.z)
            transform.localPosition += new Vector3(0, 0, Velocity * Time.deltaTime);
    }
}