using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GGJ2020;

public class EnemyBBody : Body
{
    [SerializeField] GameObject gameObjectCannon;

    GameObject gameObjectTarget;
    public override void SetDirection(Vector2 direction)
    {
        base.SetDirection(direction);
    }

    private void Start()
    {
        gameObjectTarget = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        float relativeX = gameObjectTarget.transform.position.x - transform.position.x;
        float relativeY = gameObjectTarget.transform.position.y - transform.position.y;
        float angle = Mathf.Atan2(relativeY, relativeX) * Mathf.Rad2Deg;
        // Debug.Log("Cannon:" + angle);
        gameObjectCannon.transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
    }
}
