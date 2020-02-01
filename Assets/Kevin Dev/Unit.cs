using System;
using UnityEngine;

namespace GGJ2020 {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Unit : MonoBehaviour {
        Rigidbody2D body;
        Sword sword;
        Gun gun;
        Vector2 movement;
        Vector2 orientation;
        float speed = 4;

        public void SetDirection(Vector2 direction) {
            movement = direction;
            if (direction.magnitude > 0) {
                orientation = direction.normalized;
            }
        }

        public void UseSword() {
            if (sword) {
                sword.Use(orientation);
            }
        }

        public void UseGun() {
            if (gun) {
                gun.Use(orientation);
            }
        }

        void Start() {
            body = GetComponent<Rigidbody2D>();
            sword = GetComponentInChildren<Sword>();
            gun = GetComponentInChildren<Gun>();
        }

        void Update() {
            body.velocity = movement * speed;
        }
    }
}
