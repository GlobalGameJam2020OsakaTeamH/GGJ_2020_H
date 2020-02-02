using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GGJ2020;

public class EnemyB : Enemy
{
    const float ITEM_ACCELERATE_SCORE = 1.2f;
    const float ITEM_DECELERATE_SCORE = 0.993f;
    [SerializeField] GameObject gameObjectItem;
    [SerializeField] GameObject gameObjectDestroyEffect;

    Unit unit;
    GameObject gameObjectTarget;


    int life = 5;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        unit = GetComponent<Unit>();
        gameObjectTarget = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine(IntervalShoot());
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();


    }

    public override void OnWeaponHit(Collision2D collision)
    {
        Debug.Log("Hit by player bullet");
        life--;
        if (life <= 0)
        {
            Instantiate(gameObjectDestroyEffect, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
            Destroy(gameObject);
            SpawnManager.instance.enemies -= 1;
            if (true)
            {
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(-1.0f, -1.0f), ITEM_ACCELERATE_SCORE, ITEM_DECELERATE_SCORE) ;
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(1.0f, 1.0f), ITEM_ACCELERATE_SCORE, ITEM_DECELERATE_SCORE);
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(1.0f, -1.0f), ITEM_ACCELERATE_SCORE, ITEM_DECELERATE_SCORE);
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(-1.0f, 1.0f), ITEM_ACCELERATE_SCORE, ITEM_DECELERATE_SCORE);
            }
        }
    }

    IEnumerator IntervalShoot()
    {
        while (true)
        {
            float relativeX = gameObjectTarget.transform.position.x - transform.position.x;
            float relativeY = gameObjectTarget.transform.position.y - transform.position.y;
            float relativeZ = gameObjectTarget.transform.position.z - transform.position.z;

            Vector3 relative = new Vector3(relativeX, relativeY, relativeZ);
            Vector3 normalizedRelative = Vector3.Normalize(relative);
            Vector2 direction = new Vector2(normalizedRelative.x, normalizedRelative.y);

            Debug.Log(direction);
            unit.SetDirection(direction);
            unit.UseGun();
            yield return new WaitForSeconds(0.8f);
        }
    }
}
