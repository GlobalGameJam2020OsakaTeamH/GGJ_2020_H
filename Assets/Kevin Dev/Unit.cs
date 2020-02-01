using UnityEngine;

namespace GGJ2020 {
    [RequireComponent(typeof(Rigidbody2D))]
    public class Unit : MonoBehaviour {
        Rigidbody2D body;
        Vector2 direction;
        float speed = 4;
        public void SetDirection(Vector2 direction) {
            this.direction = direction;
        }

        public void UseSword() {
            Debug.Log($"Sword");
        }

        public void UseGun() {
            Debug.Log($"Gun");
        }

        void Start() {
            body = GetComponent<Rigidbody2D>();
        }

        void Update() {
            body.velocity = direction * speed;
        }
    }
}
