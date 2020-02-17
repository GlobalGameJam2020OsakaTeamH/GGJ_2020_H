using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GGJ2020;

public class EnemyA : Enemy
{

    [SerializeField] GameObject gameObjectItem;
    [SerializeField] GameObject gameObjectDestroyEffect;

    Unit unit;
    GameObject gameObjectPlayer;
    Rigidbody2D rbody2D;

    int life = 3;

    public override void OnWeaponHit(Collision2D collision)
    {
        Debug.Log("Hit by player bullet");
        life--;
        if(life <= 0)
        {
            Instantiate(gameObjectDestroyEffect, transform.position, Quaternion.identity);
            SpawnManager.Instance.enemies -= 1;
            Destroy(gameObject);
            switch (Random.Range(0, 4))
            {
                case 1:
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 1.0f);
                    break;
                case 2:
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, -1.0f);
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 1.0f);
                    break;
                case 3:
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, -1.0f);
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 1.0f);
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, -1.0f);
                    break;
                case 4:
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, -1.0f);
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, 1.0f);
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(1.0f, -1.0f);
                    Instantiate(gameObjectItem, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector2(-1.0f, 1.0f);
                    break;

            }
        }
    }
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        unit = GetComponent<Unit>();
        gameObjectPlayer = GameObject.FindGameObjectWithTag("Player");
        rbody2D = GetComponent<Rigidbody2D>();
        Debug.Log("Start Enemy A");
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        Vector2 relative = gameObjectPlayer.transform.position - transform.position;
        Vector2 force2D = relative.normalized;


        rbody2D.velocity = force2D;
        // Debug.Log(rbody2D.velocity);
    }
}
