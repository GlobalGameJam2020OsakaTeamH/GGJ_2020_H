using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D body;
    public float speed = 8f;
    Vector2 direction;
    public void SetDirection(Vector2 direction) {
        this.direction = direction;
    }

    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    void Update() {
        body.velocity = speed * direction.normalized;
    }
}
