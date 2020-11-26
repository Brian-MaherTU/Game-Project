﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove2 : MonoBehaviour
{
    public float move = 4.5f;
    public float speed = 2.0f;
    private Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = start;
        v.y += move * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
