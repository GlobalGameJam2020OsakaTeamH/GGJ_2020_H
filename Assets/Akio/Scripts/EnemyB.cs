using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GGJ2020;

public class EnemyB : Enemy
{
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
        float relativeX = gameObjectTarget.transform.position.x - transform.position.x;
        float relativeY = gameObjectTarget.transform.position.y - transform.position.y;
        float angle = Mathf.Atan2(relativeY, relativeX) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);
    }

    public override void OnWeaponHit()
    {
        Debug.Log("Hit by player bullet");
        life--;
        if (life <= 0)
        {
            Instantiate(gameObjectDestroyEffect, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
            Destroy(gameObject);
            if (true)
            {
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(-1.0f, -1.0f));
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(1.0f, 1.0f));
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(1.0f, -1.0f));
                Instantiate(gameObjectItem, transform.position, new Quaternion(0.0f, 0.0f, 0.0f, 0.0f)).GetComponent<DroppedItem>().Initialize(new Vector2(-1.0f, 1.0f));
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
