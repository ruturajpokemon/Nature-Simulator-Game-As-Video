﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float xAxisValue = Input.GetAxis("Horizontal");
        float zAxisValue = Input.GetAxis("Vertical");
        if (Camera.current != null)
        {
            Camera.current.transform.Translate(new Vector3(xAxisValue, 0.0f, zAxisValue));
        }
    }
}
