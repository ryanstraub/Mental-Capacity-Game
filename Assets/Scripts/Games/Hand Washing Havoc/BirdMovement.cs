﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public GameObject bird;
    public float birdX;
    public float birdSpeed;

    // Update is called once per frame
    void Update()
    {
        MoveLeft();
    }

    //Bird moves on a fixed path
    public void MoveLeft()
    {
        bird.transform.Translate(-birdX * birdSpeed, 0, 0);
    }
}
