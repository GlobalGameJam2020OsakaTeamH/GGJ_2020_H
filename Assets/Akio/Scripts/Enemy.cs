﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GGJ2020;

public class Enemy : MonoBehaviour, BodyCollisionHandler
{

    public virtual void OnWeaponHit()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }
}
