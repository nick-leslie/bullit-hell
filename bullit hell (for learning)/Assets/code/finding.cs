﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finding : MonoBehaviour
{
    public GameObject player;
    public GameObject yourSelf;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player");
    }
}