using System.Collections;
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


    }

    public override void OnWeaponHit(Collision2D collision)
    {
        Debug.Log("Hit by player bullet");
        life--;
        if (life <= 0)
        {
            Instantiate(gameObjectDestroyEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            SpawnManager.Instance.enemies -= 1;
            if (true)
            {
                Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, -1.0f);
                Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 1.0f);
                Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, -1.0f);
                Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, 1.0f);
            }
        }
    }

    IEnumerator IntervalShoot()
    {
        while (true)
        {
            Vector2 relative = gameObjectTarget.transform.position - transform.position;
            Vector2 direction = relative.normalized;

            Debug.Log(direction);
            unit.SetDirection(direction);
            unit.UseGun();
            yield return new WaitForSeconds(0.8f);
        }
    }
}
