using System;
using UnityEngine;

namespace GGJ2020 {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Unit : MonoBehaviour {
        Rigidbody2D body;
        Sword sword;
        Vector2 direction;
        float speed = 4;

        public void SetDirection(Vector2 direction) {
            this.direction = direction;
        }

        public void UseSword() {
            if (sword) {
                sword.Use(direction);
            }
        }

        public void UseGun() {
            Debug.Log($"Gun");
        }

        void Start() {
            body = GetComponent<Rigidbody2D>();
            sword = GetComponentInChildren<Sword>();
        }

        void Update() {
            body.velocity = direction * speed;
        }
    }
}
