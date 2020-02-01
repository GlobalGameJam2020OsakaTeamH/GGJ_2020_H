﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GGJ2020;

public class EnemyA : Enemy
{
    Unit unit;
    GameObject gameObjectPlayer;
    Rigidbody2D rbody2D;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        unit = GetComponent<Unit>();
        gameObjectPlayer = GameObject.FindGameObjectWithTag("Player");
        rbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        float relativeX = gameObjectPlayer.transform.position.x - transform.position.x;
        float relativeY = gameObjectPlayer.transform.position.y - transform.position.y;
        float relativeZ = gameObjectPlayer.transform.position.z - transform.position.z;

        Vector3 relative = new Vector3(relativeX, relativeY, relativeZ);
        Vector3 force = Vector3.Normalize(relative);
        Vector2 force2D = new Vector2(force.x, force.y);

        rbody2D.velocity = force2D;
    }
}
