﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; //Just for debugging purposes
    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
}