﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public string myStartMessage;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(myStartMessage);
    }

    public string myUpdateMessage;
    // Update is called once per frame
    void Update()
    {
        Debug.Log(myUpdateMessage);
    }
}
