﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField]
    private float _speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementCalculation();
    }

    void MovementCalculation()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }
}