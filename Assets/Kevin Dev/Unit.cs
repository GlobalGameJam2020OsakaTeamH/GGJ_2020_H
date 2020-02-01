using System;
using UnityEngine;

namespace GGJ2020 {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Unit : MonoBehaviour {
        public LayerMask weaponLayer;
        public GameObject swordPrefab;
        public GameObject gunPrefab;

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

        void Awake() {
            if (swordPrefab) {
                GameObject swordObject = GameObject.Instantiate(swordPrefab, transform);
                swordObject.layer = weaponLayer;
                sword = swordObject.GetComponent<Sword>();
            }
            if (gunPrefab) {
                GameObject gunObject = GameObject.Instantiate(gunPrefab, transform);
                gunObject.layer = weaponLayer;
                gun = gunObject.GetComponent<Gun>();
            }
        }

        void Start() {
            body = GetComponent<Rigidbody2D>();
        }

        void Update() {
            body.velocity = movement * speed;
        }
    }
}
