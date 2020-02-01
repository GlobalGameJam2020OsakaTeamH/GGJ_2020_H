using System;
using UnityEngine;

namespace GGJ2020 {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Unit : MonoBehaviour {
        public int unitLayer;
        public int weaponLayer;
        public GameObject bodyPrefab;
        public GameObject swordPrefab;
        public GameObject gunPrefab;

        Rigidbody2D rigidBody;
        Body body;
        Sword sword;
        Gun gun;
        Vector2 movement;
        Vector2 orientation;
        float speed = 4;

        public void SetDirection(Vector2 direction) {
            movement = direction;
            if (direction.magnitude > 0) {
                orientation = direction.normalized;
                body.SetDirection(orientation);
            }
        }

        public void UseSword(Vector2 swordDirection) {
            if (sword) {
                sword.Use(swordDirection);
            }
        }

        public void UseSword() {
            UseSword(orientation);
        }

        public void UseGun(Vector2 shootDirection) {
            if (gun) {
                gun.Use(shootDirection);
            }
        }

        public void UseGun() {
            UseGun(orientation);
        }

        void Awake() {
            GameObject bodyObject = GameObject.Instantiate(bodyPrefab, transform);
            bodyObject.layer = unitLayer;
            body = bodyObject.GetComponent<Body>();

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
            rigidBody = GetComponent<Rigidbody2D>();
        }

        void Update() {
            rigidBody.velocity = movement * speed;
        }
    }
}
