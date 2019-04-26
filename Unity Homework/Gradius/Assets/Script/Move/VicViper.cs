﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VicViper : MonoBehaviour
{
    public float speed=10; //速度
    private GameObject[] bullets;//子弹类型数组


    // Start is called before the first frame update
    void Start()
    {
        bullets=Resources.LoadAll<GameObject>("Perfabs/Bullets");  
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        transform.position += (Vector3.right * h + Vector3.up * v)*Time.deltaTime*speed;

        if (Input.GetKeyDown(KeyCode.J))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullets[0], transform.position, Quaternion.identity);
    }
}
