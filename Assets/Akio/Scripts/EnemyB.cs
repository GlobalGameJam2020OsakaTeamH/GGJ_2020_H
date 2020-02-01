using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyB : Enemy
{
    GameObject gameObjectTarget;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        gameObjectTarget = GameObject.Find("VirtualPlayer");
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        float relativeX = gameObjectTarget.transform.position.x - transform.position.x;
        float relativeY = gameObjectTarget.transform.position.y - transform.position.y;
        float angle = Mathf.Atan2(relativeY, relativeX) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
    }
}
